using Day48Demo.Services.Models;
using Day48Demo.Services.Services;
using Day48Demo.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day48ASP.Pages.UsersData
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) return;

            ShowDataToUpdate();
            
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        


        private void ShowDataToUpdate()
        {
            var idText = Request.QueryString["id"];
                try
                {
                    var id = int.Parse(idText);

            var usersServices = new UsersServices();

                var users = usersServices.GetById(id);

                if(users == null)
                {
                    LabelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }
                TextBoxFirstName.Text=users.FirstName;
                TextBoxLastName.Text=users.LastName;
                TextBoxDateOfBirth1.Text = users.DateOfBirth.ToString();
                TextBoxPan.Text=users.Pan;
                TextBoxAddress.Text=users.Address;
                TextBoxGender.Text=users.Gender;
                TextBoxMObileNumber.Text = users.MobileNumber;
                TextBoxEmail.Text=users.Email;
                TextBoxComments.Text=users.Comments;
                TextBoxDepartmentRefId.Text=users.DepartmentRefId.ToString();
            }
            catch (Exception e)
            {
                LabelStatus.ShowStatusMessage($"Id{e}  parameter not found!");
            }
        }
        private void UpdateData()
        {
            var usersServices = new UsersServices();
            try
            {
                var idText = Request.QueryString["id"];

                var users = new Users();

                users.Id = int.Parse(idText);
                users.FirstName = TextBoxFirstName.Text;
                users.LastName = TextBoxLastName.Text;
                users.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth1.Text);
                users.Pan = TextBoxPan.Text;
                users.Address = TextBoxAddress.Text;
                users.Gender = rbMale.Checked ? rbMale.Text : rbFemale.Text;
                users.MobileNumber = TextBoxMObileNumber.Text;
                users.Email = TextBoxEmail.Text;
                users.Comments = TextBoxComments.Text;
                users.DepartmentRefId = int.Parse(TextBoxDepartmentRefId.Text);
                

                usersServices.Update(users);
                LabelStatus.ShowStatusMessage("Users record successfully updated!");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage(exception.ToString());
            }
        }
    }
}