using Day48Demo.Services.Services;
using Day48Demo.Services.Utilities;
using System;

using System.Data.SqlClient;


namespace Day48ASP.Pages.UsersData
{
    public partial class Delete : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) return;
            ShowDataToDelete();

        }
        protected void ButtonDelete_OnClick(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void ShowDataToDelete()
        {
            var idText = Request.QueryString["id"];
            try
            {
                var id = int.Parse(idText);

                var usersServices = new UsersServices();

                var users = usersServices.GetById(id);

                if (users == null)
                {
                    LabelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }

                LableFirstNameData.Text = users.FirstName;
                LableLastNameData.Text = users.LastName;

                LableDateOfBirthData.Text = users.DateOfBirth.ToString();
                LablePanData.Text = users.Pan;
                LableAddressData.Text = users.Address;
                LableGenderData.Text = users.Gender;
                LableMObileNumberData.Text = users.MobileNumber;
                LableEmailData.Text = users.Email;


                LableCommentsData.Text = users.Comments;
                LableDepartmentRefIdData.Text = users.DepartmentRefId.ToString();



            }
            catch (Exception e)
            {
                LabelStatus.ShowStatusMessage("Id parameter not found!");
            }
        }
    
        private void DeleteData()
        {
            var idText = Request.QueryString["id"];
            var id = int.Parse(idText);

            var usersServices = new UsersServices();

            try
            {
                //usersServices.Delete(id);

                LabelStatus.ShowStatusMessage("User record successfully deleted!");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException);
                LabelStatus.ShowStatusMessage("Failed to delete User record! Maybe a foreign key was found! Please contact database admin!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to delete User record!");
            }
        }

    }
}