<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Day48ASP.Pages.UsersData.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link rel="stylesheet" href="/www-resources/css/form.css" />
</head>
<body>
    <h1>Delete </h1>
    <form id="form1" runat="server">
        <div class="status-message">
            <asp:Label runat="server" ID="LabelStatus" Visible="false" />
        </div>
        <div>
            <table class="form-block">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelFirstName" > First Name</asp:Label></td>

                    <td>
                        <asp:Label runat="server" ID="LableFirstNameData" CssClass="readonly-data"
                            ></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                      
                        <asp:Label runat="server" ID="LabelLastName" > Last Name</asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LableLastNameData" CssClass="readonly-data"
                           ></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label runat="server" ID="LabedateOfBirth"> Date Of Birth</asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="LableDateOfBirthData" CssClass="readonly-data"
                            ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top;">
                        <asp:Label runat="server" ID="LabelPan">Pan</asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LablePanData" CssClass="readonly-dat"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelAddress"> Address</asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="LableAddressData" CssClass="readonly-data"
                            TextMode="MultiLine"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Gender" runat="server" ID="GenderLabel" CssClass="readonly-data"/>
                    </td>


                    <td>
                     <%--   <asp:RadioButton ID="rbMale" Text="Male" runat="server" GroupName="Gender" />
                        <asp:RadioButton ID="rbFemale" Text="Female" runat="server" GroupName="Gender" />--%>
                    
                          <asp:Label ID="LableGenderData"  runat="server" CssClass="readonly-data"></asp:Label>
                        </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelMObileNumber"> MobileNumber</asp:Label></td>
                    <td>
                        <asp:Label runat="server" ID="LableMObileNumberData" CssClass="readonly-data"
                             ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelEmail">Email</asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LableEmailData"  TextMode="Email" CssClass="readonly-data"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelComments"> Comments</asp:Label></td>
                    <td>

                        <asp:Label ID="LableCommentsData" runat="server" Text="true" CssClass="readonly-data "/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LabelDepartmentRefId">DepartmentRefId</asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LableDepartmentRefIdData"  CssClass="readonly-data"></asp:Label>
                    </td>
                </tr>




               

               

                <tr>


                    <td></td>
                  <td colspan="2">
                    <asp:Button runat="server" ID="ButtonDelete" Text="Delete" OnClick="ButtonDelete_OnClick" />                    
                    <a style="float: right" href="Default.aspx"><input type="button" value="Back to Listing" /></a>
                </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
