using Day48Demo.Services.Models;
using Day48Demo.Services.Services;
using Day48Demo.Services.Utilities;
using System;

namespace Day48ASP.Pages.UsersData
{
    public partial class Create : System.Web.UI.Page
    {
        protected void ButtonCreate_OnClick(object sender, EventArgs e)
        {
            CreateData();
        }

        private void CreateData()
        {
            var usersServices = new UsersServices();
            try
            {
                var users = new Users
                {
                    
                   FirstName = TextBoxFirstName.Text,
                    LastName = TextBoxLastName.Text,
                    DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text),
                    Pan = TextBoxPan.Text,
                    Address = TextBoxAddress.Text,
                    Gender = rbMale.Checked ? rbMale.Text : rbFemale.Text,
                    MobileNumber = TextBoxMObileNumber.Text,
                    Email = TextBoxEmail.Text,
                    Comments = TextBoxComments.Text,
                    DepartmentRefId = int.Parse(TextBoxDepartmentRefId.Text),
                };
                usersServices.Add(users);
                LabelStatus.ShowStatusMessage("Users record successfully added!");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to add Users record!");
            }
        } 
    }
}