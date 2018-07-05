Public Module PublicEnums
    Public Enum Priority
        VeryLow
        Low
        Normal
        High
        VeryHigh
    End Enum
    Public Enum DialogMode
        Add
        Edit
    End Enum
    Public Enum JobType
        Monthly
        Yearly
        Once
        Quarterly
        HalfYerly
    End Enum
    Public Enum CenterType
        Horizondal
        Vertical
        Both
    End Enum
    Public Enum WorkStatus
        Initialized
        OnGoing
        Suspended
        Completed
    End Enum
    Public Enum CommunicationType
        Message
        Command
        ConnectionAlert
    End Enum
    <FlagsAttribute()> _
    Public Enum UserPermissions
        System
        CreateUser
        EditUser
        ViewUser
        AddJob
        EditJob
        ViewJob
        AddWork
        EditWork
        ViewWork
        AddClient
        EditClient
        ViewClient
        ViewAllCredentials
    End Enum
    Public Enum UserType
        Administrator
        Auditor
        User
    End Enum
End Module
