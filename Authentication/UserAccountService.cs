namespace TCD.Authentication{
    public class UserAccountService{
        private List<UserAccount> _users;

        public UserAccountService(){
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "Danilo Teixeira", Email = "admin@ifnmg.edu.br", Password = "admin", Role = "Administrator" },
                new UserAccount{ UserName = "User", Email = "user@aluno.ifnmg.edu.br", Password = "user", Role = "User" },
                new UserAccount{ UserName = "Flavio Santos", Email = "frss@aluno.ifnmg.edu.br", Password = "123", Role = "User" },
                new UserAccount{ UserName = "Pedro Gabriel", Email = "pgd@aluno.ifnmg.edu.br", Password = "123", Role = "User" },
                new UserAccount{ UserName = "Maicon Leles", Email = "mpl@aluno.ifnmg.edu.br", Password = "456", Role = "User" },
                new UserAccount{ UserName = "Ivanderlei Filho", Email = "ifm@aluno.ifnmg.edu.br", Password = "789", Role = "User" },
                new UserAccount{ UserName = "Alberto Henrique", Email = "ahs@aluno.ifnmg.edu.br", Password = "147", Role = "User" }
            };
        }

        public UserAccount? GetByUserName(string userName){
            return _users.FirstOrDefault(x => x.UserName == userName);
        }

    }
}