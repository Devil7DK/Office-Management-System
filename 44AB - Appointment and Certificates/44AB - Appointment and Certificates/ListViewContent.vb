Option Strict On

Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Text.RegularExpressions

Public MustInherit Class ListViewContent

#Region "Private Methods for saving and loading the content of a ListView"

#Region "Save the whole content of a ListView with groups into a file"

	''' <summary>
	''' Saves the content of a ListView control which has no groups
	''' </summary>
	''' <param name="lsv">The ListView to be saved</param>
	''' <param name="destinationPath">The path you want to save the config file to</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Private Shared Function ListViewWithGroupsSave(ByVal lsv As ListView, ByVal destinationPath As String) As String
		Try
			' Set the encoding to Unicode
			Dim enc As New UnicodeEncoding

			' Declare a XmlTextWriter-Object, with which we are going to write the config file
			Dim XMLobj As XmlTextWriter = New XmlTextWriter(destinationPath, enc)

			With XMLobj
				.Formatting = Formatting.Indented
				.Indentation = 4

				' Open the document
				.WriteStartDocument()


				' Start the document with a node named ListView, in which will be contained all the data
				.WriteStartElement("ListView") ' <ListView>

				' The node <Columns> will contain the ColumnHeaders of the ListView
				.WriteStartElement("Columns") ' <Columns>

				' Go through all Columns in the given ListView Control and write them into the document
				For i As Integer = 0 To lsv.Columns.Count - 1
					.WriteStartElement("Column") ' <Column 

					.WriteAttributeString("text", lsv.Columns(i).Text) ' text="xyz"

					.WriteAttributeString("width", lsv.Columns(i).Width.ToString) ' width="xyz"

					.WriteAttributeString("textAlign", lsv.Columns(i).TextAlign.ToString) ' textAlign="xyz"

					.WriteEndElement() ' /> 

				Next

				' Complete the Columns-Tag
				.WriteEndElement() ' </Columns>


				' The node <Groups> will contain all Groups of The ListView
				.WriteStartElement("Groups")

				For j As Integer = 0 To lsv.Groups.Count - 1
					' <Group
					.WriteStartElement("Group")
					.WriteAttributeString("name", lsv.Groups(j).Header)
					' name="xyz"
					.WriteAttributeString("headerAlignment", lsv.Groups(j).HeaderAlignment.ToString)
					' headerAlignment="xyz">

					' Loop through the Items of the given ListView...
					For k As Integer = 0 To lsv.Groups(j).Items.Count - 1

						.WriteStartElement("item") ' <item
						.WriteAttributeString("text", lsv.Groups(j).Items(k).Text) ' text="xyz"

						' ...and SubItems to write them to the Document
						For l As Integer = 0 To lsv.Groups(j).Items(k).SubItems.Count - 2

							.WriteStartElement("subItem") ' <subItem
							.WriteAttributeString("text", lsv.Groups(j).Items(k).SubItems(l + 1).Text) ' text="xyz"

							.WriteEndElement() ' />

						Next

						' At the end of each passage in this loop, the Item-Tag will be ended to start with a new item 
						.WriteEndElement() ' </item>
					Next

					' At the end of each passage in this loop, the Group-Tag will be ended to start with a new group
					.WriteEndElement() ' </Group>
				Next

				' Complete the Groups-Tag to signalize that all groups have been written to the document
				.WriteEndElement() '</Groups>

				' Close the ListView-Tag, now we're almost done
				.WriteEndElement() ' </ListView>

				' Finally, complete the document and close the XmlTextWriter-Object
				.WriteEndDocument()
				.Close()


                '_______________________________________________________________________
                '                                                                       |
				' For instance, a configuration file is set up like this:				|
				'-----------------------------------------------------------------------|
				'   <ListView>                                                          |
				'       <Columns>                                                       |
				'			<Column text=“Column 1“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 2“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 3“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 4“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 5“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 6“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 7“ width=“100“ textAlign=“Left“ />     |
				'		</Columns>                                                      |
				'                                                                       |
				'		<Groups>                                                        |
				'			<Group name=“Group“ headerAlignment=“Left“>                 |
				'				<item text=“Description“>                               |
				'					<subItem text=“Text 0“ />                           |
				'					<subItem text=“Text 1“ />                           |
				'					<subItem text=“Text 2“ />                           |  
				'					<subItem text=“Text 3“ />                           |
				'					<subItem text=“Text 4“ />                           |
				'					<subItem text=“Text 5“ />                           |
				'				</item>                                                 |
				'			</Group>                                                    |   
				'		</Groups>                                                       |
				'	</ListView>                                                         |
				'_______________________________________________________________________|

			End With

			Return String.Empty	' If this function worked faultless, an emtpy String will bei returned
		Catch ex As Exception
			Return ex.Message ' If an error occurs during some of the operation, the exception's message will be returned
		End Try
	End Function

#End Region

#Region "Load the whole content of a ListView with groups from a file"

	''' <summary>
	''' Loads the whole content of a ListView with groups from a file
	''' </summary>
	''' <param name="lsv">The ListView to be loaded</param>
	''' <param name="loadedPath">The path to the configuration file</param>
	''' <param name="append">"True" if you want to append the saved content to the ListView. "False" if you want the ListView to be cleared before the loading begins</param>
	''' <param name="loadColumns">Indicates if the HeaderColumns should be loaded</param>
	''' <param name="addInVisibleColumn">"True" if you want that an "invisible" column will be added to the ListView.</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Private Shared Function ListViewWithGroupsLoad(ByVal lsv As ListView, ByVal loadedPath As String, Optional ByVal append As Boolean = False,
	 Optional ByVal loadColumns As Boolean = True, Optional ByVal addInVisibleColumn As Boolean = False) As String
		Try
			' If the user wants to, the ListView and its Columns are cleared, and an invisible Column will be insered to the top (index 0)
			If Not append Then lsv.Clear()
			If loadColumns Then lsv.Columns.Clear()
			If addInVisibleColumn Then lsv.Columns.Insert(0, "", 0)

			' We need an XMLReader for reading the given configuration file
			Dim XMLReader As XmlReader = New XmlTextReader(loadedPath)

			' Declare the ListViewItem, to wich the properties (text, SubItems) will be assigned
			Dim grp As New ListViewGroup
			Dim listItem As ListViewItem = New ListViewItem

			' Now we're going to read the file
			With XMLReader

				' As long as the reader hasn't come to the end of the document, this loop is executed
				Do While .Read

					' If the user wants to the Columns, read in their properties
					If loadColumns Then

						' The tag <Columns> was found; it contains the HeaderColumns of the saved ListView
						If .Name = "Column" Then
							Dim align As HorizontalAlignment = 0

							' Convert the saved textAlign-String to a HorizontalAlignment
							Select Case .GetAttribute("textAlign").ToLower
								Case "left"
									align = HorizontalAlignment.Left
								Case "right"
									align = HorizontalAlignment.Right
								Case "center"
									align = HorizontalAlignment.Center
							End Select

							' Add the columns with the loaded properties (text, width, text alignment)
							lsv.Columns.Add(.GetAttribute("text"), Convert.ToInt32(.GetAttribute("width")), align)
						End If

					End If

					' The tag <Group> was found; it contains the name of the group and its text alignment
					If .Name = "Group" Then

						'If the Tag is a StartElement (<Group>, and not </Group>), the ListView is added all the saved Groups
						If .IsStartElement Then
							Dim align As HorizontalAlignment = 0

							' Convert the saved textAlign-String to a HorizontalAlignment
							Select Case .GetAttribute("headerAlignment").ToLower
								Case "left"
									align = HorizontalAlignment.Left
								Case "right"
									align = HorizontalAlignment.Right
								Case "center"
									align = HorizontalAlignment.Center
							End Select

							' Set the required properties of the ListViewGroup (name and text alignment)
							grp = New ListViewGroup(.GetAttribute("name"), align)

							' Add the group to the ListView
							lsv.Groups.Add(grp)
						End If
					End If

					' The item-Tag was found; it contains the text of each Item and their SubItems
					If .Name = "item" Then

						' If the Tag is a StartElement (<item>; and not </item>), assign the property "text" to the ListViewItem
						If .IsStartElement Then
							If addInVisibleColumn Then
								listItem.SubItems.Add(.GetAttribute("text"))
							Else
								listItem.Text = .GetAttribute("text")
							End If
						Else

							' Otherwise, if it's an EndTag (</item>), the previously filled ListViewItem is added to the ListView
							listItem.Group = grp
							lsv.Items.Add(listItem)
							listItem = New ListViewItem
						End If
					End If

					' The Element <subItem> was found; it contains the SubItem's text
					If .Name = "subItem" Then
						' The ListView is added a SubItem with the attribute "text" from the element <subItem>
						listItem.SubItems.Add(.GetAttribute("text"))
					End If

				Loop

				.Close() ' Close the XMLTextReader

			End With

			' Name all Groups as like their Headers
			For i As Integer = 0 To lsv.Groups.Count - 1
				lsv.Groups(i).Name = lsv.Groups(i).Header
			Next

			Return String.Empty	' If this function worked faultless, an emtpy String will bei returned
		Catch ex As Exception
			Return ex.Message ' If an error occurs during some of the operation, the exception's message will be returned
		End Try
	End Function

#End Region


#Region "Save the whole content of a ListView without groups into a file"

	''' <summary>
	''' Saves the content of a ListView control which has groups
	''' </summary>
	''' <param name="lsv">The ListView to be saved</param>
	''' <param name="destinationPath">The path you want to save the config file to</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Private Shared Function ListViewWithNoGroupsSave(ByVal lsv As ListView, ByVal destinationPath As String) As String
		Try
			' Set the encoding to Unicode
			Dim enc As New UnicodeEncoding

			' Declare a XmlTextWriter-Object, with which we are going to write the config file
			Dim XMLobj As XmlTextWriter = New XmlTextWriter(destinationPath, enc)

			With XMLobj
				.Formatting = Formatting.Indented
				.Indentation = 4

				' Open the document
				.WriteStartDocument()

				' Start the document with a node named ListView, in which will be contained all the data
				.WriteStartElement("ListView") ' <ListView>

				' The node <Columns> will contain the ColumnHeaders of the ListView
				.WriteStartElement("Columns") ' <Columns>

				' Go through all Columns in the given ListView Control and write them into the document
				For i As Integer = 0 To lsv.Columns.Count - 1

					.WriteStartElement("Column") ' <Column 

					.WriteAttributeString("text", lsv.Columns(i).Text) ' text="xyz"

					.WriteAttributeString("width", lsv.Columns(i).Width.ToString) ' width="xyz"

					.WriteAttributeString("textAlign", lsv.Columns(i).TextAlign.ToString) ' textAlign="xyz"

					.WriteEndElement() ' /> 

				Next

				' Complete the Columns-Tag
				.WriteEndElement() ' </Columns>


				' The node <Items> will contain all Items of the ListView
				.WriteStartElement("Items")	' <Items>

				' Loop through the given ListView's items...
				For k As Integer = 0 To lsv.Items.Count - 1

					.WriteStartElement("item") ' <item
					.WriteAttributeString("text", lsv.Items(k).Text) ' text="xyz">

					' ...and SubItems to write them to the Document
					For l As Integer = 0 To lsv.Items(k).SubItems.Count - 2

						.WriteStartElement("subItem") ' <subItem
						.WriteAttributeString("text", lsv.Items(k).SubItems(l + 1).Text)	' text="xyz"

						.WriteEndElement()	' />

					Next

					' At the end of each passage in the main loop, the Item-Tag will be ended to start with a new item 
					.WriteEndElement() ' </item>
				Next

				' Complete the Items-Tag to signalize that all items have been written to the document
				.WriteEndElement() ' </Items>

				' Close the ListView-Tag, now we're almost done
				.WriteEndElement() ' </ListView>

				' Finally, complete the document and close the XmlTextWriter-Object
				.WriteEndDocument()
				.Close()


				'_______________________________________________________________________
				'                                                                       |
				' For instance, a configuration file is set up like this:				|
				'-----------------------------------------------------------------------|
				'   <ListView>                                                          |
				'       <Columns>                                                       |
				'			<Column text=“Column 1“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 2“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 3“ width=“100“ textAlign=“Left“ />     |
				'			<Column text=“Column 4“ width=“100“ textAlign=“Left“ />     |
				'		</Columns>                                                      |
				'		<Items>	                                                        |
				'				<item text=“item #1“>									|
				'					<subItem text=“Text 0“ />                           |
				'					<subItem text=“Text 1“ />                           |
				'					<subItem text=“Text 2“ />                           |  
				'				</item>                                                 |
				'				<item text=“item #2“>									|
				'					<subItem text=“Text 0“ />                           |
				'					<subItem text=“Text 1“ />                           |
				'					<subItem text=“Text 2“ />                           |  
				'				</item>                                                 |
				'		</Items>														|
				'	</ListView>                                                         |
				'_______________________________________________________________________|

			End With

			Return String.Empty	' If this function worked faultless, an emtpy String will bei returned
		Catch ex As Exception
			Return ex.Message ' If an error occurs during some of the operation, the exception's message will be returned
		End Try
	End Function

#End Region

#Region "Load the whole content of a ListView without groups from a file"

	''' <summary>
	''' Loads the whole content of a ListView without groups from a file
	''' </summary>
	''' <param name="lsv">The ListView to be loaded</param>
	''' <param name="loadedPath">The path to the configuration file</param>
	''' <param name="append">"True" if you want to append the saved content to the ListView. "False" if you want the ListView to be cleared before the loading begins</param>
	''' <param name="loadColumns">Indicates if the HeaderColumns should be loaded</param>
	''' <param name="addInVisibleColumn">"True" if you want that an "invisible" column will be added to the ListView.</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Private Shared Function ListViewWithNoGroupsLoad(ByVal lsv As ListView, ByVal loadedPath As String, Optional ByVal append As Boolean = False,
	Optional ByVal loadColumns As Boolean = True, Optional ByVal addInVisibleColumn As Boolean = False) As String
		Try
			' If the user wants to, the ListView and its Columns are cleared, and an invisible Column will be insered to the top (index 0)
			If Not append Then lsv.Clear()
			If loadColumns Then lsv.Columns.Clear()
			If addInVisibleColumn Then lsv.Columns.Insert(0, "", 0)

			' We need an XMLReader for reading the given configuration file
			Dim XMLReader As XmlReader = New XmlTextReader(loadedPath)

			' Declare the ListViewItem, to wich the properties (text, SubItems) will be assigned
			Dim listItem As ListViewItem = New ListViewItem

			' Now we're going to read the file
			With XMLReader

				' As long as the reader hasn't come to the end of the document, this loop is executed
				Do While .Read

					' If the user wants to the Columns, read in their properties
					If loadColumns Then

						' The tag <Columns> was found; it contains the HeaderColumns of the saved ListView
						If .Name = "Column" Then
							Dim align As HorizontalAlignment = 0

							' Convert the saved textAlign-String to a HorizontalAlignment
							Select Case .GetAttribute("textAlign").ToLower
								Case "left"
									align = HorizontalAlignment.Left
								Case "right"
									align = HorizontalAlignment.Right
								Case "center"
									align = HorizontalAlignment.Center
							End Select

							' Add the columns with the loaded properties (text, width, text alignment)
							lsv.Columns.Add(.GetAttribute("text"), Convert.ToInt32(.GetAttribute("width")), align)
						End If
					End If

					' The item-Tag was found; it contains the text of each Item and their SubItems
					If .Name = "item" Then

						' If the Tag is a StartElement (<item>; and not </item>), assign the property "text" to the ListViewItem
						If .IsStartElement Then
							If addInVisibleColumn Then
								listItem.SubItems.Add(.GetAttribute("text"))
							Else
								listItem.Text = .GetAttribute("text")
							End If
						Else

							' Otherwise, if it's an EndTag (</item>), the previously filled ListViewItem is added to the ListView
							lsv.Items.Add(listItem)
							listItem = New ListViewItem
						End If
					End If

					' The Element <subItem> was found; it contains the SubItem's text
					If .Name = "subItem" Then

						' The ListView is added a SubItem with the attribute "text" from the element <subItem>
						listItem.SubItems.Add(.GetAttribute("text"))
					End If

				Loop

				.Close() ' Close the XMLTextReader

			End With

			' Name all Groups as like their Headers
			For i As Integer = 0 To lsv.Groups.Count - 1
				lsv.Groups(i).Name = lsv.Groups(i).Header
			Next

			Return String.Empty	' If this function worked faultless, an emtpy String will bei returned
		Catch ex As Exception
			Return ex.Message ' If an error occurs during some of the operation, the exception's message will be returned
		End Try
	End Function

#End Region

#End Region

	''' <summary>
	''' Saves the content of a ListView control which has no groups
	''' </summary>
	''' <param name="lsv">The ListView to be saved</param>
	''' <param name="destinationPath">The path you want to save the config file to</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Public Shared Function Save(ByVal lsv As ListView, ByVal destinationPath As String) As String

		If lsv.Groups.Count > 0 AndAlso lsv.ShowGroups Then
			Return ListViewWithGroupsSave(lsv, destinationPath)
        Else
            Return ListViewWithNoGroupsSave(lsv, destinationPath)
        End If

	End Function

	''' <summary>
	''' Loads the whole content of a ListView
	''' </summary>
	''' <param name="lsv">The ListView to be loaded</param>
	''' <param name="loadedPath">The path to the configuration file</param>
	''' <param name="append">"True" if you want to append the saved content to the ListView. "False" if you want the ListView to be cleared before the loading begins</param>
	''' <param name="loadColumns">Indicates if the HeaderColumns should be loaded</param>
	''' <param name="addInVisibleColumn">"True" if you want that an "invisible" column will be added to the ListView.</param>
	''' <returns>If no errors occur the function returns an empty String, otherwise the Exception's Message</returns>
	Public Shared Function Load(ByVal lsv As ListView, ByVal loadedPath As String, Optional ByVal append As Boolean = False,
	  Optional ByVal loadColumns As Boolean = True, Optional ByVal addInVisibleColumn As Boolean = False) As String

		Dim hasFileGroups As Boolean =
		 Regex.IsMatch(File.ReadAllText(loadedPath).Replace(Chr(10), ""), "(<groups>.*</groups>)|(<groups />)",
		 RegexOptions.IgnoreCase)

		If hasFileGroups Then
			Return ListViewWithGroupsLoad(lsv, loadedPath, append, loadColumns, addInVisibleColumn)

		Else
			Return ListViewWithNoGroupsLoad(lsv, loadedPath, append, loadColumns, addInVisibleColumn)

		End If

	End Function

End Class