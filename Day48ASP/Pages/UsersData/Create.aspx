<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Day48ASP.Pages.UsersData.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/www-resources/css/form.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="status-message">
            <asp:Label runat="server" ID="LabelStatus" Visible="false" />
        </div>
        <div>
            <table class="form-block">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelFirstName"> First Name</asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxFirstName" placeholder="Enter user First Name"
                            MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top;">
                        <asp:Label runat="server" ID="LabelLastName">Last Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxLastName" placeholder=" Enter user Last Name"
                            MaxLength="50"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabeladteOfBirth"> Date Of Birth</asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxDateOfBirth" placeholder="Enter user Date Of Birth"
                            TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top;">
                        <asp:Label runat="server" ID="LabelPan">Pan</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxPan" placeholder=" Enter user Pan"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelAddress"> Address</asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxAddress" placeholder="Enter user Address"
                            TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Gender" runat="server" ID="GenderLabel" />
                    </td>


                    <td>
                        <asp:RadioButton ID="rbMale" Text="Male" runat="server" GroupName="Gender" />
                        <asp:RadioButton ID="rbFemale" Text="Female" runat="server" GroupName="Gender" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelMObileNumber"> MobileNumber</asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxMObileNumber" placeholder="Enter user Mobile Number"
                             TextMode="Phone" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelEmail">Email</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxEmail" placeholder=" Enter user Email"  TextMode="Email"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelComments"> Comments</asp:Label></td>
                    <td>

                        <asp:CheckBox ID="TextBoxComments" runat="server" Text="true" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelDepartmentRefId">DepartmentRefId</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBoxDepartmentRefId" placeholder=" Enter user Department Ref Id"></asp:TextBox>
                    </td>
                </tr>



                <tr>


                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="ButtonCreate" Text="Create" OnClick="ButtonCreate_OnClick" />
                        <a style="float: right" href="Default.aspx">
                            <input type="button" value="Back to Listing" /></a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
