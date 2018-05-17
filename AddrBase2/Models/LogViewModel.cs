using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AddrBase2.Models
    {
    public class LogViewModel
        {
        private List<LogViewModel> listAccounts = new List<LogViewModel>();
        
        [Required]
        [Display( Name = "Логин" )]
        public string UserName { get; set; }
        [Required]
        [Display( Name = "Запомнить?" )]
        public bool RememberMe { get; set; }
        [Required]
        [DataType( DataType.Password )]
        [Display( Name = "Пароль" )]
        public string Password { get; set; }
        


        }
    }

        
    