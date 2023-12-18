Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.DirectoryServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel


Module Connector
    Dim CurrentDate As DateTime = DateTime.Now
    Dim FormatteDate As String = CurrentDate.ToString("yyyy-MM-dd")
    Dim conn As New MySqlConnection
    Dim strquery, query As String
    Dim reader As MySqlDataReader
    Dim dbname, server, username, password As String
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dataTable As New DataTable
    Dim dataSet As New DataSet
    Dim UserID As String


    Public Sub Dbconnection()
        dbname = "it2adreamstash"
        server = "127.0.0.1"
        username = "root" '
        password = "password"
        'check connection'
        If Not conn Is Nothing Then
            conn.Close()
            'establish the connection'
            conn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";password=" & password & ";database=" & dbname & ""
            Try
                conn.Open()
                MsgBox("Connected to MySQL Database!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub ReloadDB()
        conn.Close()
        dbname = "it2adreamstash"
        server = "127.0.0.1"
        username = "root" '
        password = "password"
        'check connection'
        If Not conn Is Nothing Then
            conn.Close()
            'establish the connection'
            conn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";password=" & password & ";database=" & dbname & ""
            Try
                conn.Open()
                'MsgBox("Connected to MySQL Database!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'Register , Login , Forgot Pass , Log out
    Public Sub AccRegister()
        query = "INSERT INTO users(FirstName, LastName, UserName, Pass, Department, Course, Section, YearLevel, DataRegistered, UserRole, AccountStatus) VALUES(@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Date, @Role, @Status)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Param1", Register.txtFirstName.Text)
        cmd.Parameters.AddWithValue("@Param2", Register.txtLastName.Text)
        cmd.Parameters.AddWithValue("@Param3", Register.txtUsernameReg.Text)
        cmd.Parameters.AddWithValue("@Param4", Register.txtPasswordReg.Text)
        cmd.Parameters.AddWithValue("@Param5", Register.cbxDepartment.Text)
        cmd.Parameters.AddWithValue("@Param6", Register.CbxCourse.Text)
        cmd.Parameters.AddWithValue("@Param7", Register.cbxSection.Text)
        cmd.Parameters.AddWithValue("@Param8", Register.cbxYearLevel.Text)
        'cmd.Parameters.AddWithValue("@Param9", Register.txtConfirmPasswordReg.Text)
        cmd.Parameters.AddWithValue("@Date", FormatteDate)
        cmd.Parameters.AddWithValue("@Role", "Donor")
        cmd.Parameters.AddWithValue("@Status", "Active")
        Try
            cmd.ExecuteNonQuery()
            ' Registration successful. Show Panel
            Register.Hide()
            Registration_Successful.Show()
        Catch ex As Exception
            ' Handle any errors.
            MessageBox.Show(ex.Message)
        Finally
            RegisterClearData()
        End Try
    End Sub

    Private Sub RegisterClearData()
        Register.txtFirstName.Clear()
        Register.txtLastName.Clear()
        Register.txtUsernameReg.Clear()
        Register.txtPasswordReg.Clear()
        Register.cbxDepartment.SelectedIndex = -1
        Register.CbxCourse.SelectedIndex = -1
        Register.cbxSection.SelectedIndex = -1
        Register.cbxYearLevel.SelectedIndex = -1
        'Register.txtConfirmPasswordReg.Clear()

    End Sub
    Public Sub AccLogin()

        query = "SELECT UserName, Pass, UserID, UserRole, AccountStatus FROM users WHERE UserName = @UserName AND Pass = @Pass"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", Login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@Pass", Login.txtPassword.Text)

        Try
            Dim reader1 As MySqlDataReader = cmd.ExecuteReader()

            If reader1.HasRows Then

                reader1.Read()
                UserID = reader1("UserID").ToString
                Dim UserRole As String = reader1("UserRole")
                Dim Status As String = reader1("AccountStatus")

                'MsgBox(UserID + " " + UserRole + " " + Status)

                If Status = "Active" Then

                    ' Successful login.
                    MsgBox("Login successful.")
                    Login.Hide()
                    cmd.Dispose()
                    reader1.Close()

                    If UserRole = "Donor" Then
                        DonorDashboard()
                        DonorDashb.Show()

                    ElseIf UserRole = "Assistant Administrator" Then
                        AsstAdminDashboard()
                        AssistantAdminDashboard.Show()

                    ElseIf UserRole = "Administrator" Then
                        AdminDashboard()
                        AdminDashb.Show()

                    Else
                        MsgBox("Error has occured")
                        Application.Exit()

                    End If

                ElseIf Status = "Deactivated" Then
                    'MsgBox("Account is locked! Please reach out to System Administrator")
                    Login.lblLoginMessage.Text = "Account is locked!" + vbCrLf + "Contact System Administrator."
                    'cmd.Dispose()
                    reader1.Close()
                    ReloadDB()
                    'Login.Show()

                End If

            Else
                ' Invalid login.
                'MsgBox("Invalid username or password.")
                Login.lblLoginMessage.Text = "Invalid Username/Password!"

                ' Show the Login form again
                'Login.Show()
                reader1.Close()
                ReloadDB()

            End If

        Catch ex As Exception
            ' Handle any errors.
            MsgBox("Error: " & ex.Message)
        Finally
            LoginClear()
        End Try
    End Sub

    Public Sub LogOut()

        MsgBox("You have successfully logged out!")
        LoginClear()
        ReloadDB()
        Get_Started.Show()

    End Sub


    Private Sub LoginClear()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
        'Login.txtUsername.Focus()

    End Sub
    Public Sub forgotpass()
        Dim resetUsername As String = ForgotPassword.txtFPUsername.Text
        Dim currentPassword As String = ForgotPassword.txtFPCurrentPassword.Text
        Dim newPassword As String = ForgotPassword.txtFPNewPassword.Text
        Dim retypeNewPass As String = ForgotPassword.txtFPRetypeNewPass.Text

        ' Check if the new password and retype new password match
        If newPassword = retypeNewPass Then
            ' Perform the password reset
            query = "UPDATE users SET Pass = @NewPassword WHERE UserName = @Username AND Pass = @CurrentPassword"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NewPassword", newPassword)
            cmd.Parameters.AddWithValue("@Username", resetUsername)
            cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword)

            Try
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Password reset successful
                    MsgBox("Password reset successful.")
                    ForgotPassword.Show()
                Else
                    ' Invalid username or current password
                    MsgBox("Invalid username or current password.")
                    ForgotPassword.Show()
                End If

            Catch ex As Exception
                ' Handle any errors.
                MsgBox("Error: " & ex.Message)
            End Try

        Else
            ' Password and retype password do not match
            MsgBox("New password and retype new password do not match.")
            ForgotPassword.Show()
        End If

        ' Clear the password reset form fields
        ResetPasswordClearData()
    End Sub

    Private Sub ResetPasswordClearData()
        ForgotPassword.txtFPUsername.Clear()
        ForgotPassword.txtFPCurrentPassword.Clear()
        ForgotPassword.txtFPNewPassword.Clear()
        ForgotPassword.txtFPRetypeNewPass.Clear()
    End Sub

    'Dashboard Donor, Admin, Asst Admin
    Public Sub DonorDashboard()

        DonorDashb.lblUserID.Text = UserID
        ' Assuming you have stored the donor's first and last name in the database,
        ' and you have retrieved them when the donor logs in.

        ' Query to retrieve donor's first and last name based on their username
        query = "SELECT FirstName, LastName, UserName FROM users WHERE UserName = @UserName"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", Login.txtUsername.Text)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Display the donor's full name in the label
                DonorDashb.lblDonorFirstLastName.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()
                DonorDashb.lblUsername.Text = reader("UserName").ToString
            End If

            reader.Close()
        Catch ex As Exception
            ' Handle any errors.
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub AdminDashboard()

        query = "SELECT FirstName, LastName FROM users WHERE UserName = @UserName"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", Login.txtUsername.Text)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                AdminDashb.lblAdminFirstLastName.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub AsstAdminDashboard()

        query = "SELECT FirstName, LastName FROM users WHERE UserName = @UserName"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", Login.txtUsername.Text)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                AssistantAdminDashboard.lblAdminFirstLastName.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub DonorAccountSettingClear()
        DonorAccountSetting.txtAccountSettingFirstName.Clear()
        DonorAccountSetting.txtAccountSettingLastName.Clear()
        DonorAccountSetting.txtAccountSettingUsername.Clear()
        DonorAccountSetting.txtAccountSettingPassword.Clear()
        DonorAccountSetting.cbxASDepartment.SelectedIndex = -1
        DonorAccountSetting.cbxASSection.SelectedIndex = -1
        DonorAccountSetting.cbxASYearLevel.SelectedIndex = -1
        DonorAccountSetting.cbxASCourse.SelectedIndex = -1
    End Sub


    Public Sub ChangeUpdateDonorAccountSettings(ByVal UserID As Integer)
        Dim UpdateFirstname As String = DonorAccountSetting.txtAccountSettingFirstName.Text
        Dim UpdateLastname As String = DonorAccountSetting.txtAccountSettingLastName.Text
        Dim UpdateUsername As String = DonorAccountSetting.txtAccountSettingUsername.Text
        Dim UpdatePassword As String = DonorAccountSetting.txtAccountSettingPassword.Text
        Dim UpdateDepartment As String = DonorAccountSetting.cbxASDepartment.Text
        Dim UpdateSection As String = DonorAccountSetting.cbxASSection.Text
        Dim UpdateYearLevel As String = DonorAccountSetting.cbxASYearLevel.Text
        Dim UpdateCourse As String = DonorAccountSetting.cbxASCourse.Text

        Dim query As String = "UPDATE users SET FirstName = @firstname, LastName = @lastname, UserName = @username, Pass = @password, Department = @department, Section = @section, YearLevel = @year_level, Course = @course WHERE UserID = @UserID"

        Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstname", UpdateFirstname)
                cmd.Parameters.AddWithValue("@lastname", UpdateLastname)
                cmd.Parameters.AddWithValue("@username", UpdateUsername)
                cmd.Parameters.AddWithValue("@password", UpdatePassword)
                cmd.Parameters.AddWithValue("@department", UpdateDepartment)
                cmd.Parameters.AddWithValue("@section", UpdateSection)
                cmd.Parameters.AddWithValue("@year_level", UpdateYearLevel)
                cmd.Parameters.AddWithValue("@course", UpdateCourse)
                cmd.Parameters.AddWithValue("@UserID", UserID)

                Try
                    conn.Open()
                    ' Execute the query to update the user's record
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Update successful
                        MsgBox("Account settings updated.")
                    Else
                        ' No rows affected (UserID not found)
                        MsgBox("No user found with the provided UserID.")
                    End If
                Catch ex As Exception
                    ' Handle any errors
                    MsgBox("Error updating account settings: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub AdminAddUsers()
        ReloadDB()
        ' Fetching values from the AdminAddUser form fields
        Dim FirstName As String = AdminAddUser.txtAdminFirstName.Text
        Dim LastName As String = AdminAddUser.txtAdminLastName.Text
        Dim Department As String = AdminAddUser.cbxAdminDepartment.Text
        Dim Section As String = AdminAddUser.cbxAdminSection.Text
        Dim YearLevel As String = AdminAddUser.cbxAdminYearLevel.Text
        Dim Course As String = AdminAddUser.CbxAdminCourse.Text
        Dim Username As String = AdminAddUser.txtAdminUsername.Text
        Dim Password As String = AdminAddUser.txtAdminPassword.Text
        Dim FormatteDate As String = CurrentDate.ToString("yyyy-MM-dd")


        ' SQL query to insert a new admin user into the database
        Dim query As String = "INSERT INTO users(FirstName, LastName, UserName, Pass, Department, Course, Section, YearLevel, DataRegistered) VALUES(@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Date)"
        Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
            Using cmd As New MySqlCommand(query, conn)
                ' Assigning parameter values
                cmd.Parameters.AddWithValue("@Param1", FirstName)
                cmd.Parameters.AddWithValue("@Param2", LastName)
                cmd.Parameters.AddWithValue("@Param3", Username)
                cmd.Parameters.AddWithValue("@Param4", Password)
                cmd.Parameters.AddWithValue("@Param5", Department)
                cmd.Parameters.AddWithValue("@Param6", Course)
                cmd.Parameters.AddWithValue("@Param7", Section)
                cmd.Parameters.AddWithValue("@Param8", YearLevel)
                cmd.Parameters.AddWithValue("@Date", FormatteDate)
                Try
                    conn.Open()
                    ' Execute the query to add the new admin user
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Admin user added successfully
                        MsgBox("Admin user added successfully!")
                        ' Clear form fields after successful addition
                        AdminAddUser.Show()
                    Else
                        ' Handle scenario where no rows were affected
                        MsgBox("Failed to add admin user.")
                    End If
                Catch ex As Exception
                    ' Handle any errors
                    MsgBox("Error adding admin user: " & ex.Message)
                Finally
                    AdminAddUserClear()
                End Try
            End Using
        End Using
    End Sub
    Public Sub AdminAddUserClear()
        AdminAddUser.txtAdminFirstName.Clear()
        AdminAddUser.txtAdminLastName.Clear()
        AdminAddUser.cbxAdminDepartment.SelectedIndex = -1
        AdminAddUser.cbxAdminSection.SelectedIndex = -1
        AdminAddUser.cbxAdminYearLevel.SelectedIndex = -1
        AdminAddUser.CbxAdminCourse.SelectedIndex = -1
        AdminAddUser.txtAdminUsername.Clear()
        AdminAddUser.txtAdminPassword.Clear()
    End Sub

    Public Sub AdminDeleteUser(ByVal UserID As Integer)
        ReloadDB()
        ' SQL query to delete a user based on UserID
        query = "DELETE FROM users WHERE UserID = @UserID"
        Try
            Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
                Using cmd As New MySqlCommand(query, conn)
                    ' Add UserID parameter to the query
                    cmd.Parameters.AddWithValue("@UserID", UserID)

                    ' Open the connection and execute the query
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Deletion successful
                        MsgBox("User deleted successfully.")
                        SearchAdminUsers()
                        AdminUsers.Show()
                    Else
                        ' No user found with the provided UserID
                        MsgBox("No user found with the provided UserID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during database operations
            MsgBox("Error deleting user: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub SearchAdminUsers()
        ReloadDB()
        ' Get the search query from the TextBox
        Dim searchQuery As String = AdminUsers.txtAdminSearchUsers.Text.Trim()

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT UserID, FirstName, LastName, UserName, UserRole, AccountStatus, Department, Course, Section, YearLevel FROM users WHERE UserID LIKE @searchQuery OR FirstName LIKE @searchQuery OR LastName LIKE @searchQuery OR UserName LIKE @searchQuery OR Pass LIKE @searchQuery OR Department LIKE @searchQuery OR Course LIKE @searchQuery OR Section LIKE @searchQuery OR YearLevel LIKE @searchQuery"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add a parameter for search input
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchQuery & "%")

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminUsers.dgvAdminUsers.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Public Sub PopulateUsers(ByVal UserID As Integer)

        ReloadDB()
        query = "SELECT UserName, Pass, FirstName, LastName, Department, Course, YearLevel, Section, UserRole, AccountStatus FROM users WHERE UserID=@UserID"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserID", UserID)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                'AssistantAdminDashb.lblAdminFirstLastName.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()

                AdminUpdateUsers.txtAdminUpdateUserFirstName.Text = reader("FirstName").ToString
                AdminUpdateUsers.txtAdminUpdateUserLastName.Text = reader("LastName").ToString
                AdminUpdateUsers.txtAdminUpdateUserName.Text = reader("UserName").ToString
                AdminUpdateUsers.cbxAdminUpdateUserDepartment.Text = reader("Department").ToString
                AdminUpdateUsers.cbxAdminUpdateUserYearLevel.Text = reader("YearLevel").ToString
                AdminUpdateUsers.cbxAdminUpdateUserCourse.Text = reader("Course").ToString
                AdminUpdateUsers.cbxAdminUpdateUserSection.Text = reader("Section").ToString
                AdminUpdateUsers.cbxAdminUpdateUserRole.Text = reader("UserRole").ToString
                AdminUpdateUsers.cbxAdminUpdateUserStatus.Text = reader("AccountStatus").ToString
                Dim pass As String = reader("Pass").ToString
                AdminUpdateUsers.lblOldPass.Text = pass
                AdminUpdateUsers.txtAdminUpdateUserPassword.Text = pass
                AdminUpdateUsers.txtAdminUpdateUserPasswordConfirm.Text = pass
                AdminUpdateUsers.lblUserID.Text = UserID.ToString

                AdminUpdateUsers.Show()

            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try


    End Sub

    Public Sub ChangeUpdateAdminUsers(ByVal UserID As Integer)

        Dim FirstName As String = AdminUpdateUsers.txtAdminUpdateUserFirstName.Text
        Dim LastName As String = AdminUpdateUsers.txtAdminUpdateUserLastName.Text
        Dim UserName As String = AdminUpdateUsers.txtAdminUpdateUserName.Text
        Dim Department As String = AdminUpdateUsers.cbxAdminUpdateUserDepartment.Text
        Dim Section As String = AdminUpdateUsers.cbxAdminUpdateUserSection.Text
        Dim YearLevel As String = AdminUpdateUsers.cbxAdminUpdateUserYearLevel.Text
        Dim Course As String = AdminUpdateUsers.cbxAdminUpdateUserCourse.Text
        Dim UserRole As String = AdminUpdateUsers.cbxAdminUpdateUserRole.Text
        Dim AccountStatus As String = AdminUpdateUsers.cbxAdminUpdateUserStatus.Text
        Dim NewPassword As String = AdminUpdateUsers.txtAdminUpdateUserPasswordConfirm.Text

        Dim FormatDate As String = CurrentDate.ToString("yyyy-MM-dd")


        Dim query As String = "UPDATE users SET FirstName = @firstname, LastName = @lastname, UserName= @username, Department = @department, Section = @section, YearLevel = @yearlevel, Course = @course, LastChange =@formatdate, UserRole = @userrole, AccountStatus = @accountstatus, Pass = @newpassword WHERE UserID = @UserID"
        'Dim query As String = "UPDATE users SET FirstName = @firstname, LastName = @lastname, UserName= @username, Department = @department, Section = @section, YearLevel = @yearlevel, Course = @course, UserRole = @userrole, AccountStatus = @accountstatus WHERE UserID = @UserID"

        Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstname", FirstName)
                cmd.Parameters.AddWithValue("@lastname", LastName)
                cmd.Parameters.AddWithValue("@username", UserName)
                cmd.Parameters.AddWithValue("@department", Department)
                cmd.Parameters.AddWithValue("@section", Section)
                cmd.Parameters.AddWithValue("@yearlevel", YearLevel)
                cmd.Parameters.AddWithValue("@course", Course)
                cmd.Parameters.AddWithValue("@formatdate", FormatDate)
                cmd.Parameters.AddWithValue("@userrole", UserRole)
                cmd.Parameters.AddWithValue("@accountstatus", AccountStatus)
                cmd.Parameters.AddWithValue("@newpassword", NewPassword)
                cmd.Parameters.AddWithValue("@UserID", UserID)

                Try
                    conn.Open()
                    ' Execute the query to update the user's record
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Update successful
                        MsgBox("User has been updated!")
                        AdminUpdateUsers.Close()
                        SearchAdminUsers()
                    Else
                        ' No rows affected (UserID not found)
                        MsgBox("Error has occured, user not updated!")
                    End If
                Catch ex As Exception
                    ' Handle any errors
                    MsgBox("Error updating account settings: " & ex.Message)
                Finally

                End Try
            End Using
        End Using
    End Sub

    Public Sub AdminUpdateUsersClear()
        AdminUpdateUsers.txtAdminUpdateUserPassword.Clear()
        AdminUpdateUsers.txtAdminUpdateUserPasswordConfirm.Clear()
        AdminUpdateUsers.txtAdminUpdateUserPassword.Focus()
    End Sub

    Public Sub AdminCreateCampaign()
        ReloadDB()

        ' Fetching values from the AdminAddUser form fields
        Dim CampaignTitle As String = AdminCampaign.txtAdminNewCampaignTitle.Text
        Dim CampaignDescription As String = AdminCampaign.txtAdminNewCampaignDescription.Text
        Dim DonationGoal As String = AdminCampaign.txtAdminNewDonationGoal.Text
        Dim asDecimal As Decimal = Decimal.Parse(DonationGoal)
        Dim BeneficiaryName As String = AdminCampaign.txtAdminCampaignBeneName.Text
        Dim StartDate As DateTime = AdminCampaign.dtpAdminStartDate.Value ' Use the Value property of DateTimePicker
        Dim EndDate As DateTime = AdminCampaign.dtpAdminEndDate.Value ' Use the Value property of DateTimePicker

        ' Insert the campaign details into the database
        Dim query As String = "INSERT INTO campaignentries (CampaignTitle, CampaignDescription, StartDate, EndDate, DonationGoal, BeneficiaryName, CampaignStatus) 
        VALUES (@Title, @Description, @StartDate, @EndDate, @DonationGoal, @BeneficiaryName, @CampaignStatus)"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Title", CampaignTitle)
            cmd.Parameters.AddWithValue("@Description", CampaignDescription)
            cmd.Parameters.AddWithValue("@StartDate", StartDate)
            cmd.Parameters.AddWithValue("@EndDate", EndDate)
            cmd.Parameters.AddWithValue("@DonationGoal", asDecimal)
            cmd.Parameters.AddWithValue("@BeneficiaryName", BeneficiaryName)
            cmd.Parameters.AddWithValue("CampaignStatus", "Active")
            Try
                'conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Campaign created successfully!" & vbCrLf & "Donation Goal: Php " & DonationGoal)
                AdminCampaign.Show()
                SearchCampaigns()
            Catch ex As Exception
                MsgBox("Error creating campaign: " & ex.Message)
            Finally
                conn.Close()
                AdminCampaignClear()
            End Try
        End Using
    End Sub

    Public Sub AdminCampaignClear()
        AdminCampaign.txtAdminNewCampaignTitle.Clear()
        AdminCampaign.txtAdminNewCampaignDescription.Clear()
        AdminCampaign.txtAdminNewDonationGoal.Clear()
        AdminCampaign.txtAdminCampaignBeneName.Clear()
        AdminCampaign.dtpAdminStartDate.Value = DateTime.Now ' Set the DateTimePicker to the current date
        AdminCampaign.dtpAdminEndDate.Value = DateTime.Now ' Set the DateTimePicker to the current date
    End Sub

    Public Sub SearchCampaigns()
        ReloadDB()

        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary ID"" FROM campaignentries;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminCampaign.dgvAdminNewCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub


    Public Sub AdminSearchCampaigns()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchTitle As String = AdminCampaign.txtpnlAdminNewCampaignTitle.Text.Trim()
        Dim searchStatus As String = AdminCampaign.cbxAdminNewCampaignStatus.Text

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary ID"" FROM campaignentries
            WHERE (DonationCampaignID LIKE @searchQuery OR CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR StartDate LIKE @searchQuery OR 
            EndDate LIKE @searchQuery OR DonationGoal LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) AND CampaignStatus=@CampaignStatus"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignStatus", searchStatus)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminCampaign.dgvAdminNewCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Public Sub PopulateCampaign(ByVal CampaignID As Integer)

        ReloadDB()
        query = "SELECT DonationCampaignID, CampaignTitle, CampaignStatus, CampaignDescription, StartDate, EndDate, DonationGoal, BeneficiaryName, CampaignStatus FROM campaignentries WHERE DonationCampaignID=@CampaignID"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@CampaignID", CampaignID)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                'AssistantAdminDashb.lblAdminFirstLastName.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()

                AdminUpdateCampaign.txtpnlAdminUpdateCampaignTitle.Text = reader("CampaignTitle").ToString
                AdminUpdateCampaign.cbxAdminUpdateCampaignStatus.Text = reader("CampaignStatus").ToString
                AdminUpdateCampaign.txtEditCampaignDesc.Text = reader("CampaignDescription").ToString
                AdminUpdateCampaign.dtpEditAdminStartDate.Value = reader("StartDate").ToString
                AdminUpdateCampaign.dtpEditAdminEndDate.Value = reader("EndDate").ToString
                AdminUpdateCampaign.txtAdminUpdateCampaignDonationGoal.Text = reader("DonationGoal").ToString
                AdminUpdateCampaign.txtEditCampaignBeneName.Text = reader("BeneficiaryName").ToString
                AdminUpdateCampaign.lblCampaignID.Text = CampaignID.ToString

                AdminUpdateCampaign.Show()

            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub ChangeUpdateAdminCampaigns(ByVal CampaignID As Integer)

        ReloadDB()

        Dim CampaignTitle As String = AdminUpdateCampaign.txtpnlAdminUpdateCampaignTitle.Text
        Dim CampaignDescription As String = AdminUpdateCampaign.txtEditCampaignDesc.Text
        Dim StartDate As DateTime = AdminUpdateCampaign.dtpEditAdminStartDate.Value
        Dim EndDate As DateTime = AdminUpdateCampaign.dtpEditAdminEndDate.Value
        Dim BeneficiaryName As String = AdminUpdateCampaign.txtEditCampaignBeneName.Text
        Dim CampaignStatus As String = AdminUpdateCampaign.cbxAdminUpdateCampaignStatus.Text

        Dim DonationGoal As String = AdminUpdateCampaign.txtAdminUpdateCampaignDonationGoal.Text
        'Dim UserRole As String = AdminCampaign.cbxAdminUpdateUserRole.Text

        Dim query As String = "UPDATE campaignentries SET CampaignStatus = @CampaignStatus, CampaignTitle = @CampaignTitle, CampaignDescription = @CampaignDescription, StartDate= @StartDate, EndDate = @EndDate, DonationGoal = @DonationGoal, BeneficiaryName = @BeneficiaryName WHERE DonationCampaignID = @CampaignID"
        'Dim query As String = "UPDATE users SET FirstName = @firstname, LastName = @lastname, UserName= @username, Department = @department, Section = @section, YearLevel = @yearlevel, Course = @course, UserRole = @userrole, AccountStatus = @accountstatus WHERE UserID = @UserID"

        Try
            Dim asDecimal As Decimal = Decimal.Parse(DonationGoal).ToString("##,###0.00")
            MsgBox("Formatted DonationGoal: " & asDecimal.ToString)

            Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CampaignStatus", CampaignStatus)
                    cmd.Parameters.AddWithValue("@CampaignTitle", CampaignTitle)
                    cmd.Parameters.AddWithValue("@CampaignDescription", CampaignDescription)
                    cmd.Parameters.AddWithValue("@StartDate", StartDate)
                    cmd.Parameters.AddWithValue("@EndDate", EndDate)
                    cmd.Parameters.AddWithValue("@DonationGoal", asDecimal)
                    cmd.Parameters.AddWithValue("@BeneficiaryName", BeneficiaryName)
                    cmd.Parameters.AddWithValue("@CampaignID", CampaignID)

                    Try
                        conn.Open()
                        ' Execute the query to update the user's record
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Update successful
                            MsgBox("Campaigns has been updated!")
                            AdminUpdateCampaign.Close()
                            SearchCampaigns()
                            AdminCampaign.Show()
                        Else
                            ' No rows affected (UserID not found)
                            MsgBox("Error has occured, Campaigns not updated!")
                        End If
                    Catch ex As Exception
                        ' Handle any errors
                        MsgBox("Error updating campaigns settings: " & ex.Message)
                    Finally
                        AdminCampaignClear()
                    End Try


                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        End Try

    End Sub



    ' ADMIN DONATION SUB 
    Public Sub DonationSearchCampaigns()
        ReloadDB()

        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            ' Only Query ACTIVE CAMPAIGNS
            Dim query As String = "SELECT DonationCampaignID ""ID"",  
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries 
            WHERE CampaignStatus = 'ACTIVE' ;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminDonation.dgvAdminDonation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Public Sub DonationSearchCampaignsFilter()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchID As String = AdminDonation.txtAdminDonationSearch.Text
        Dim searchTitle As String = AdminDonation.txtAdminDonationSearch.Text.Trim()

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()
            Dim query As String


            If Not String.IsNullOrWhiteSpace(searchID) And Not String.IsNullOrWhiteSpace(searchTitle) Then
                ' Query to select data from the database based on search input
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) 
                AND DonationCampaignID=@CampaignID AND CampaignStatus='ACTIVE';"

            ElseIf Not String.IsNullOrWhiteSpace(searchID) Then
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE DonationCampaignID=@CampaignID AND CampaignStatus='ACTIVE';"

            Else
                ' Query to select data from the database based on search input
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery 
                OR DonationCampaignID=@CampaignID) AND CampaignStatus='ACTIVE';"

            End If

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignID", searchID)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminDonation.dgvAdminDonation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub


    ' ADMIN DONATION ENTRY Sub

    Public Sub AdminDonationEntry()

        ' Fetching values from the AdminDonation form fields
        Dim CampaignID As Integer
        Dim asDecimal As Decimal

        Dim DonationAmount As String = AdminDonation.txtpnlAdminDonationAmount.Text
        Dim username As String = AdminDonation.txtpnlAdminDonorInformation.Text
        Dim DonationDate As DateTime = AdminDonation.dtpDonationDate.Value

        AdminDonation.lblID.Text = 0
        AdminDonation.lblUserName.Text = 0

        Try
            CampaignID = Integer.Parse(AdminDonation.txtpnlAdminDonationCampaignID.Text)
            asDecimal = Decimal.Parse(DonationAmount).ToString("##,###0.00")

            DonationCampaignID(CampaignID)
            DonationUsername(username)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        If AdminDonation.lblID.Text = 0 And AdminDonation.lblUserName.Text = 0 Then
            ReloadDB()
            ' Insert the campaign details into the database
            Dim query As String = "INSERT INTO donations (DonationDate, Donor, CampaignSupported,CampaignTitle, DonationAmount) 
            VALUES (@Date, @Donor, @CampaignID, @CampaignTitle, @Amount)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Date", DonationDate)
                cmd.Parameters.AddWithValue("@Donor", username)
                cmd.Parameters.AddWithValue("@CampaignID", CampaignID)
                cmd.Parameters.AddWithValue("@CampaignTitle", AdminDonation.lblTitle.Text)
                cmd.Parameters.AddWithValue("@Amount", asDecimal)
                Try
                    'conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Donation added successfully!" & vbCrLf & "Donation Amount: Php " & asDecimal.ToString)
                    AdminDonation.Show()
                    DonationUpdateCampaign(CampaignID, asDecimal)
                    DonationSearchCampaigns()
                    DonationClear()

                Catch ex As Exception
                    MsgBox("Error adding donation: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using

        ElseIf AdminDonation.lblID.Text = 1 And AdminDonation.lblUserName.Text = 0 Then
            MsgBox("Campaign doesn't exists!")
            DonationClear()

        ElseIf AdminDonation.lblUserName.Text = 1 And AdminDonation.lblID.Text = 0 Then
            MsgBox("Username doesn't exists!")
            DonationClear()

        Else
            MsgBox("Campaign ID and Username don't exists!")
            DonationClear()

        End If

    End Sub

    Public Sub DonationClear()

        AdminDonation.lblID.Text = 0
        AdminDonation.lblUserName.Text = 0
        AdminDonation.txtpnlAdminDonationCampaignID.Clear()
        AdminDonation.txtpnlAdminDonorInformation.Clear()
        AdminDonation.txtpnlAdminDonationAmount.Clear()
        AdminDonation.txtpnlAdminDonationCampaignID.Focus()

    End Sub

    Public Sub DonationCampaignID(ByVal CampaignID As Integer)

        'This is to check if campaignID exists 
        ReloadDB()

        query = "SELECT DonationCampaignID, CampaignTitle FROM campaignentries WHERE DonationCampaignID=@CampaignID"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@CampaignID", CampaignID)

        Dim ID As String = "0"
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ID = reader("DonationCampaignID").ToString
                AdminDonation.lblTitle.Text = reader("CampaignTitle").ToString
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        End Try

        If ID = "0" Then
            AdminDonation.lblID.Text = 1
        End If

    End Sub

    Public Sub DonationUsername(ByVal Donor As String)

        'This is to check if Donor Username exists
        ReloadDB()

        query = "SELECT UserID, UserName FROM users WHERE UserName=@Donor"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Donor", Donor)

        Dim ID As String = "0"
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ID = reader("UserID").ToString
                Donor = reader("UserName").ToString
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        If ID = "0" Then
            AdminDonation.lblUserName.Text = 1
        End If

    End Sub

    Public Sub DonationUpdateCampaign(CampaignID As Integer, Amount As Decimal)

        'This is to search for the last Donation Amount of the CampaingID 
        Dim LastAmount As Decimal
        ReloadDB()

        query = "SELECT DonationCampaignID, AmountDonated FROM campaignentries WHERE DonationCampaignID=@CampaignID"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@CampaignID", CampaignID)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                LastAmount = Decimal.Parse(reader("AmountDonated").ToString)
                'MsgBox(LastAmount)
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try


        ' ADD LASTAMOUNT to DONATION AMOUNT
        Dim NEWTOTAL As Decimal = LastAmount + Amount

        ' THIS IS TO UPDATE THE AMOUNTDONATED TO NEW TOTAL 

        ReloadDB()
        Dim queryUpdate As String = "UPDATE campaignentries SET AmountDonated = @NewTotal WHERE DonationCampaignID = @CampaignID"

        Try
            NEWTOTAL = Decimal.Parse(NEWTOTAL).ToString("##,###0.00")

            Using conn As New MySqlConnection("server = 127.0.0.1; user id = root; password = password ;database = it2adreamstash")
                Using cmd As New MySqlCommand(queryUpdate, conn)
                    cmd.Parameters.AddWithValue("@NewTotal", NEWTOTAL)
                    cmd.Parameters.AddWithValue("@CampaignID", CampaignID)

                    Try
                        conn.Open()
                        ' Execute the query to update the user's record
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Update successful
                            MsgBox("Campaign Total Donation has been updated!")
                        Else
                            ' No rows affected (UserID not found)
                            MsgBox("Error has occured, Campaigns not updated!")
                        End If
                    Catch ex As Exception
                        ' Handle any errors
                        MsgBox("Error updating campaigns: " & ex.Message)
                    Finally
                    End Try

                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        End Try

    End Sub


    ' DONATION HISTORY 
    Public Sub DonationHistory(ByVal Donor As String)
        ReloadDB()

        Try
            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationID ""ID"",  
            DonationDate ""Donation Date"", Donor ""Donor Name"" CampaignSupported ""Campaign ID"", CampaignTitle ""Campaign Title"", DonationAmount ""Amount Donated"" 
            FROM donations WHERE Donor=@Donor"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("Donor", Donor)
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorHistory.dgAdminHistory.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub
    Public Sub pnlAdminHome1()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT COUNT(*) FROM campaignentries WHERE CampaignStatus = ""Active"";"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim ActiveCampaigns As Object = cmd.ExecuteScalar()

                If ActiveCampaigns IsNot Nothing Then
                    AssistantAdminHome.lblAdminHome1.Text = ActiveCampaigns.ToString()
                    AssistantAdminHome.lblAdminHome1.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub pnlAdminHome2()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT count(distinct donor) FROM donations;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim TotalDonors As Object = cmd.ExecuteScalar()

                If TotalDonors IsNot Nothing Then
                    AssistantAdminHome.lblAdminHome2.Text = TotalDonors.ToString()
                    AssistantAdminHome.lblAdminHome2.Show()

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub pnlAdminHome3()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT sum(DonationAmount) FROM donations;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim TotalDonors As Object = cmd.ExecuteScalar()

                If TotalDonors IsNot Nothing Then
                    AssistantAdminHome.lblAdminHome3.Text = TotalDonors.ToString()
                    AssistantAdminHome.lblAdminHome3.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub RefreshLabels()
        ' Call your existing methods or consolidate the logic here
        pnlAdminHome1()
        pnlAdminHome2()
        pnlAdminHome3()
    End Sub
    Public Sub DonorCampaigns()
        ReloadDB()

        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorCampaign.dgvDonorCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub DonorSearchCampaigns()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchTitle As String = DonorCampaign.txtDonorSearch.Text.Trim()
        Dim searchStatus As String = DonorCampaign.cbxAdminNewCampaignStatus.Text

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries
            WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR StartDate LIKE @searchQuery OR 
            EndDate LIKE @searchQuery OR DonationGoal LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) AND CampaignStatus=@CampaignStatus"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignStatus", searchStatus)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorCampaign.dgvDonorCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub AdminDonationHistory()
        ReloadDB()

        Try
            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationID ""ID"", Donor ""Donor Name"",
            DonationDate ""Donation Date"", CampaignSupported ""Campaign ID"", CampaignTitle ""Campaign Title"", DonationAmount ""Amount Donated"" 
            FROM donations"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorHistory.dgAdminHistory.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub
    Public Sub SearchAssistantUsers()
        ReloadDB()
        ' Get the search query from the TextBox
        Dim searchQuery As String = AssistantAdminUser.txtAssistantAdminSearchUsers.Text.Trim()

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT UserID, FirstName, LastName, UserName, UserRole, AccountStatus, Department, Course, Section, YearLevel FROM users WHERE UserID LIKE @searchQuery OR FirstName LIKE @searchQuery OR LastName LIKE @searchQuery OR UserName LIKE @searchQuery OR Pass LIKE @searchQuery OR Department LIKE @searchQuery OR Course LIKE @searchQuery OR Section LIKE @searchQuery OR YearLevel LIKE @searchQuery"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add a parameter for search input
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchQuery & "%")

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AssistantAdminUser.dgvAssistantAdminUsers.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Public Sub AssistantSearchCampaigns()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchTitle As String = AssistantAdminCampaign1.txtAssistantSearch.Text.Trim()
        Dim searchStatus As String = AssistantAdminCampaign1.cbxAssistantNewCampaignStatus.Text

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries
            WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR StartDate LIKE @searchQuery OR 
            EndDate LIKE @searchQuery OR DonationGoal LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) AND CampaignStatus=@CampaignStatus"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignStatus", searchStatus)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AssistantAdminCampaign1.dgvAssistantAdminCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub AssistantDonationSearchCampaignsFilter()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchID As String = AssistantAdminDonation1.txtpnlAssistantDonationCampaignID.Text
        Dim searchTitle As String = AssistantAdminDonation1.txtpnlAssistantDonationAmount.Text.Trim()

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()
            Dim query As String


            If Not String.IsNullOrWhiteSpace(searchID) And Not String.IsNullOrWhiteSpace(searchTitle) Then
                ' Query to select data from the database based on search input
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) 
                AND DonationCampaignID=@CampaignID AND CampaignStatus='ACTIVE';"

            ElseIf Not String.IsNullOrWhiteSpace(searchID) Then
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE DonationCampaignID=@CampaignID AND CampaignStatus='ACTIVE';"

            Else
                ' Query to select data from the database based on search input
                query = "SELECT DonationCampaignID ""ID"",  CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description    "", 
                StartDate ""Start Date"", EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", 
                BeneficiaryName ""Beneficiary Name"" FROM campaignentries
                WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery 
                OR DonationCampaignID=@CampaignID) AND CampaignStatus='ACTIVE';"

            End If

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignID", searchID)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AssistantAdminDonation1.dgvAssistantDonation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub AssistantDonationEntry()

        ' Fetching values from the AdminDonation form fields
        Dim CampaignID As Integer
        Dim asDecimal As Decimal

        Dim DonationAmount As String = AssistantAdminDonation1.txtpnlAssistantDonationAmount.Text
        Dim username As String = AssistantAdminDonation1.txtpnlAssistantDonorInformation.Text
        Dim DonationDate As DateTime = AssistantAdminDonation1.dtpAssistantDonationDate.Value

        AssistantAdminDonation1.lblID.Text = 0
        AssistantAdminDonation1.lblUserName.Text = 0

        Try
            CampaignID = Integer.Parse(AssistantAdminDonation1.txtAssistantDonationCampaignID.Text)
            asDecimal = Decimal.Parse(DonationAmount).ToString("##,###0.00")

            DonationCampaignID(CampaignID)
            DonationUsername(username)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        If AssistantAdminDonation1.lblID.Text = 0 And AssistantAdminDonation1.lblUserName.Text = 0 Then
            ReloadDB()
            ' Insert the campaign details into the database
            Dim query As String = "INSERT INTO donations (DonationDate, Donor, CampaignSupported,CampaignTitle, DonationAmount) 
            VALUES (@Date, @Donor, @CampaignID, @CampaignTitle, @Amount)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Date", DonationDate)
                cmd.Parameters.AddWithValue("@Donor", username)
                cmd.Parameters.AddWithValue("@CampaignID", CampaignID)
                cmd.Parameters.AddWithValue("@CampaignTitle", AdminDonation.lblTitle.Text)
                cmd.Parameters.AddWithValue("@Amount", asDecimal)
                Try
                    'conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Donation added successfully!" & vbCrLf & "Donation Amount: Php " & asDecimal.ToString)
                    AssistantAdminDonation1.Show()
                    DonationUpdateCampaign(CampaignID, asDecimal)
                    DonationSearchCampaigns()
                    DonationClear()

                Catch ex As Exception
                    MsgBox("Error adding donation: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using

        ElseIf AssistantAdminDonation1.lblID.Text = 1 And AssistantAdminDonation1.lblUserName.Text = 0 Then
            MsgBox("Campaign doesn't exists!")
            DonationClear()

        ElseIf AssistantAdminDonation1.lblUserName.Text = 1 And AssistantAdminDonation1.lblID.Text = 0 Then
            MsgBox("Username doesn't exists!")
            DonationClear()

        Else
            MsgBox("Campaign ID and Username don't exists!")
            DonationClear()

        End If

    End Sub
    Public Sub AsstRefreshLabels()
        ' Call your existing methods or consolidate the logic here
        pnlAsstAdminHome1()
        pnlAsstAdminHome2()
        pnlAsstAdminHome3()
    End Sub

    Public Sub pnlAsstAdminHome1()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT COUNT(*) FROM campaignentries WHERE CampaignStatus = ""Active"";"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim ActiveCampaigns As Object = cmd.ExecuteScalar()

                If ActiveCampaigns IsNot Nothing Then
                    AdminHome.lblAdminHome1.Text = ActiveCampaigns.ToString()
                    AdminHome.lblAdminHome1.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub pnlAsstAdminHome2()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT COUNT(Donor) FROM donations;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim TotalDonors As Object = cmd.ExecuteScalar()

                If TotalDonors IsNot Nothing Then
                    AdminHome.lblAdminHome2.Text = TotalDonors.ToString()
                    AdminHome.lblAdminHome2.Show()

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub pnlAsstAdminHome3()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT sum(DonationAmount) FROM donations;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim TotalDonors As Object = cmd.ExecuteScalar()

                If TotalDonors IsNot Nothing Then
                    AdminHome.lblAdminHome3.Text = TotalDonors.ToString()
                    AdminHome.lblAdminHome3.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub pnlDonorHome1()
        ReloadDB()

        Try

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT COUNT(*) FROM campaignentries WHERE CampaignStatus = ""Active"";"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                Dim ActiveCampaigns As Object = cmd.ExecuteScalar()

                If ActiveCampaigns IsNot Nothing Then
                    DonorHome.lblAdminHome1.Text = ActiveCampaigns.ToString()
                    DonorHome.lblAdminHome1.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
    Public Sub DonorHomeSearchCampaigns()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchTitle As String = AdminCampaign.txtpnlAdminNewCampaignTitle.Text.Trim()
        Dim searchStatus As String = AdminCampaign.cbxAdminNewCampaignStatus.Text

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"", CampaignStatus ""Status"", 
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries
            WHERE (CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR StartDate LIKE @searchQuery OR 
            EndDate LIKE @searchQuery OR DonationGoal LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) AND CampaignStatus=@CampaignStatus"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignStatus", searchStatus)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminCampaign.dgvAdminNewCampaign.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub DonorDonationHistory2(ByVal Donor As String)
        ReloadDB()
        ' Get the search query from the TextBox

        Try
            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationID ""ID"",  
            DonationDate ""Donation Date"", CampaignSupported ""Campaign ID"", CampaignTitle ""Campaign Title"", DonationAmount ""Amount Donated"" 
            FROM donations WHERE Donor=@Donor"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("Donor", Donor)
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorDonationHisto2.dgvDonorHistory.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub
    Public Sub AdminSearchBene()
        ReloadDB()
        ' Get the search query from the TextBox
        Dim searchQuery As String = AdminBene.txtAdminSearchBene.Text.Trim()
        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT * FROM beneficiaries WHERE BeneficiaryID LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery OR BeneficiaryInfo LIKE @searchQuery OR CampaignTitle LIKE @searchQuery;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchQuery & "%")
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminBene.dgvAdminBene.DataSource = dataTable

            ' Set the AutoSizeMode property of each column to Fill
            For Each column As DataGridViewColumn In AdminBene.dgvAdminBene.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub AdminSearchDonation2()
        ReloadDB()

        ' Get the search queries from the TextBoxes
        Dim searchTitle As String = AdminDonation.txtAdminDonationSearch.Text.Trim()
        Dim searchStatus As String = AdminCampaign.cbxAdminNewCampaignStatus.Text

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT DonationCampaignID ""ID"",
            CampaignTitle ""Campaign Title"", CampaignDescription ""Campaign Description        "", StartDate ""Start Date"", 
            EndDate ""End Date"", DonationGoal ""Donation Goal"", AmountDonated ""Amount Donated"", BeneficiaryName ""Beneficiary Name"" FROM campaignentries
            WHERE (DonationCampaignID LIKE @searchQuery OR CampaignTitle LIKE @searchQuery OR CampaignDescription LIKE @searchQuery OR StartDate LIKE @searchQuery OR 
            EndDate LIKE @searchQuery OR DonationGoal LIKE @searchQuery OR AmountDonated LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery) AND CampaignStatus=@CampaignStatus"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchTitle & "%")
                cmd.Parameters.AddWithValue("@CampaignStatus", searchStatus)

                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            AdminDonation.dgvAdminDonation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub AdminAddBene()
        ReloadDB()

        ' Fetching values from the AdminAddUser form fields
        Dim BeneficiaryName As String = AdminBene.txtBeneName.Text
        Dim BeneficiaryInfo As String = AdminBene.txtBeneInfo.Text
        Dim CampaignTitle As String = AdminBene.txtBeneCampaign.Text

        ' Insert the campaign details into the database
        Dim query As String = "INSERT INTO beneficiaries (BeneficiaryName, BeneficiaryInfo, CampaignTitle) 
        VALUES (@BeneficiaryName, @BeneficiaryInfo, @CampaignTitle)"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BeneficiaryName", BeneficiaryName)
            cmd.Parameters.AddWithValue("@BeneficiaryInfo", BeneficiaryInfo)
            cmd.Parameters.AddWithValue("@CampaignTitle", CampaignTitle)
            Try
                'conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Beneficiary Added!" & vbCrLf)
                AdminSearchBene()
            Catch ex As Exception
                MsgBox("Error adding: " & ex.Message)
            Finally
                conn.Close()
                AdminBene.txtBeneName.Clear()
                AdminBene.txtBeneInfo.Clear()
            End Try
        End Using
    End Sub
    Public Sub AdminSearchHisto2()
        ReloadDB()
        ' Get the search query from the TextBox
        Dim searchQuery As String = DonorHistory.txtAdminSearchHistory.Text.Trim()
        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            'query to select data from the database based on search input
            Dim query As String = "SELECT DonationID ""ID"", Donor ""Donor Name"",
            DonationDate ""Donation Date"", CampaignSupported ""Campaign ID"", CampaignTitle ""Campaign Title"", DonationAmount ""Amount Donated""
            FROM donations WHERE DonationID LIKE @searchQuery OR DonationDate LIKE @searchQuery OR Donor LIKE @searchQuery 
            OR CampaignSupported LIKE @searchQuery OR CampaignTitle LIKE @searchQuery OR DonationAmount LIKE @searchQuery;"

            'Dim query As String = "Select * from donations"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchQuery & "%")
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorHistory.dgAdminHistory.DataSource = dataTable


            Dim cr As New CR_DonationHistory
            'cr.SetDataSource(dataTable)
            DonorPrintShow.CrystalReportViewer1.ReportSource = cr
            DonorPrintShow.CrystalReportViewer1.SelectionFormula = "{donations1.Donor} = 'Romz'"
            DonorPrintShow.CrystalReportViewer1.Refresh()
            'DonorPrintShow.CrystalReportViewer1.RefreshReport()

            'cr.Close()
            'cr.Dispose()

            ' Set the AutoSizeMode property of each column to Fill
            For Each column As DataGridViewColumn In AdminBene.dgvAdminBene.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
    Public Sub DonorSearchBene()
        ReloadDB()
        ' Get the search query from the TextBox
        Dim searchQuery As String = DonorBene.txtDonorSearchBene.Text.Trim()
        'This is search without FILTERS!

        Try
            ' Open the connection
            'conn.Open()

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Query to select data from the database based on search input
            Dim query As String = "SELECT * FROM beneficiaries WHERE BeneficiaryID LIKE @searchQuery OR BeneficiaryName LIKE @searchQuery OR BeneficiaryInfo LIKE @searchQuery OR CampaignTitle LIKE @searchQuery;"

            ' Create a MySqlCommand to execute the query with parameters
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for search inputs
                cmd.Parameters.AddWithValue("@searchQuery", "%" & searchQuery & "%")
                ' Create a MySqlDataAdapter to fill the DataTable with filtered data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DonorBene.dgvDonorBene.DataSource = dataTable

            ' Set the AutoSizeMode property of each column to Fill
            For Each column As DataGridViewColumn In DonorBene.dgvDonorBene.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
End Module