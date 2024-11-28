<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regration page.aspx.cs" Inherits="Hote_registrations.Regration_page" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class ="auto-Style1" style ="background-color:bisque">
                <caption><h1>Registration</h1></caption>
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="FNametxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Rfv1" runat="server" ControlToValidate="FNametxt" ErrorMessage="First name textbox can't be left" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="LNametxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Rfv2" runat="server" ControlToValidate="LNametxt" ErrorMessage="This field is can't be left empty" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="UNametxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Rfv3" runat="server" ControlToValidate="UNametxt" ErrorMessage="This field can't be left empty" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="Gender"/>
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="Gender" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="others" GroupName="Gender" />
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Rfv4" runat="server" ControlToValidate="Passwordtxt" Display="Dynamic" ErrorMessage="This field cannot be left empty" ForeColor="Red" SetFocusOnError="True" Enabled="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>ConformPassword</td>
                    <td>
                        <asp:TextBox ID="CPtxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="Cmv1" runat="server" ControlToCompare="Passwordtxt" ControlToValidate="CPtxt" ErrorMessage="Should match to password" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="Emailtxt" Display="Dynamic" ErrorMessage="Given input is email formate" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="Phonetxt" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RevPhone" runat="server" ControlToValidate="Phonetxt" Display="Dynamic" ErrorMessage="Contect no. can either be land Phone (6-8Digite)or(10)digits" ForeColor="Red" SetFocusOnError="True" ValidationExpression=": ^\d{6,8}$|^[6-9]\d{9}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="Addresstxt" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Rfvaddress" runat="server" ControlToValidate="Addresstxt" ErrorMessage="Address field can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CVAddress" runat="server" ControlToValidate="Addresstxt" ErrorMessage="Address  should be minimum 50characters of length" ForeColor="Red"></asp:CustomValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="Agetxt" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Agetxt" Display="Dynamic" ErrorMessage="Age greaterthan 18-60" ForeColor="Red" MaximumValue="60" MinimumValue="18" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Languages Known</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Telugu" />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="English" />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Hindi" />
                    </td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="select Country" value ="NS"/>
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>Srilanka</asp:ListItem>
                            <asp:ListItem>America</asp:ListItem>
                            <asp:ListItem>Nepal</asp:ListItem>
                            <asp:ListItem>Bangladesh</asp:ListItem>
                            <asp:ListItem>Afganistan</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="Rfvcountry" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Select  one country" ForeColor="Red" InitialValue="NS" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" class="auto-style1">
                        <asp:Button ID="Rigbtn" runat="server" Text="Register" OnClick="Rigbtn_Click" BackColor="Red" BorderColor="#660066" BorderStyle="Double" BorderWidth="10px" ForeColor="Blue" Height="45px" Width="100px"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
