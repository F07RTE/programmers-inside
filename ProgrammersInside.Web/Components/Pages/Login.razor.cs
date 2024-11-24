// <auto-generated />
using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProgrammersInside.Web.Core.UserContext.CoreInterfaces;

namespace ProgrammersInside.Web.Components.Pages
{
    public partial class Login : ComponentBase
    {
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] IUserProvider UserProvider {get; set;} = null!;

        private string Email { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        private bool IsPasswordShow { get; set; }
        private InputType PasswordInput { get; set; } = InputType.Password;
        private string PasswordInputIcon { get; set; } = Icons.Material.Filled.VisibilityOff;
        private string Error { get; set; } = string.Empty;

        private void ShowPassword()
        {
            if (IsPasswordShow)
            {
                IsPasswordShow = false;
                PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                PasswordInput = InputType.Password;
            }
            else
            {
                IsPasswordShow = true;
                PasswordInputIcon = Icons.Material.Filled.Visibility;
                PasswordInput = InputType.Text;
            }
        }

        private void SignIn()
        {
            var user = UserProvider.GetUser(Email);

            if(user == null || user?.Password != Password)
            {
                Error = "E-mail ou senha inválido";
                return;
            }

            NavigationManager.NavigateTo("/home");
        }
    }
}