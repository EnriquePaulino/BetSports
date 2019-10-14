using BetSports.Web.Data.Entities;
using BetSports.Web.Helpers;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckComparny(1, "Consorcio JC Sport", "Santiago");
            await CheckRoles();
            var manager = await CheckUserAsync("Enrique", "Paulino", "paulinoenrique@gmail.com", "809 710 5012", "Edif.Altagracia III, C/Exiterre Apt.4a", "Manager");
            await CheckManagerAsync(manager);
            await CheckLanguageAsync();
            await CheckLeagueAsync();
            await CheckTypePlayAsync();
        }

        private async Task CheckComparny(
            int idType,
            string name,
            string address)
        {
            if (!_context.Companies.Any())
            {
                _context.Companies.Add(new Entities.Company {
                    IdType = idType, 
                    Name = name, 
                    Address = address,
                    Status = true
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task<User> CheckUserAsync(
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }


        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Manager");
            await _userHelper.CheckRoleAsync("Owner");
            await _userHelper.CheckRoleAsync("Lessee");
        }

        private async Task CheckManagerAsync(User user)
        {
            if (!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckLanguageAsync()
        {
            if (!_context.Languages.Any())
            {
                _context.Languages.Add(new Entities.Language { Name = "English", Status = true });
                _context.Languages.Add(new Entities.Language { Name = "Spanish", Status = true });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckLeagueAsync()
        {
            if (!_context.Leagues.Any())
            {
                _context.Leagues.Add(new Entities.League { Name = "Liga Dominicana de Béisbol", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Argentina Copa Argentina", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Argentina Primera División", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Baseball Players", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Belgium Jupiler League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Boxing League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Brazil Copa Do Brasil", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Brazil Serie A", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "CONCACAF Champions League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Canadian Football League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Caribbean Baseball League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Copa Libertadores", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Copa Sudamericana", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Coppa Italia", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "England", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "FIFA", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "FIFA Confederations Cup", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "France Coupe", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "France Ligue 1", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Germany Bundesliga", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Italy Serie A", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Liga Mexicana de Beisbol", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Liga Mexicana del Pacifico", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Liga Venezonala de Béisbol Profesional", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Major League Soccer", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Mexico Copa MX", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Mexico Primera División", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "NBA MatchUps", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "NBA Solo", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "NFL Solo", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "National Basketball Association", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "National College Basketball Association", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "National Collegiate Athletic Association Football", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "National Football League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Netherlands Eredivisie", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Portugal Primeira Liga", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Russia Premier League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Spain Copa del Rey", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Spain La Liga", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Turkey Super Lig", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Turkish Airlines Euroleague", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "UEFA Champion League", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "Womens National Basketball Association", Status = true });
                _context.Leagues.Add(new Entities.League { Name = "World Cup", Status = true });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypePlayAsync()
        {
            if (!_context.TypePlays.Any())
            {
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en primera mitad a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en primera mitad a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego Completo", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Run Line", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Equipo solo a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Equipo solo a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Super Run Line", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Pitcher ponches a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Pitcher ponches a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Run Line alternativo", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Sancocho(RHE) a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Sancocho(RHE) a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 equipo solo a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 equipo solo a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2 a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2 a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3 a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3 a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 equipo solo a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 equipo solo a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en segunda mitad a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en segunda mitad a menos", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia a mas", Status = true });
                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia a menos", Status = true });
                await _context.SaveChangesAsync();
            }
        }
    }
}


//public class SeedDb
//    {
//        private readonly DataContext _context;
//        private readonly IUserHelper _userHelper;

//        public SeedDb(
//            DataContext context,
//            IUserHelper userHelper)
//        {
//            _context = context;
//            _userHelper = userHelper;
//        }

//        public async Task SeedAsync()
//        {
//            await _context.Database.EnsureCreatedAsync();
//            await CheckRoles();
//            var manager = await CheckUserAsync("Enrique", "Paulino", "paulinoenrique@gmail.com", "809 710 5012", "Edif.Altagracia III, C/Exiterre Apt.4a", "Manager");
//            await CheckManagerAsync(manager);
//            await CheckLanguageAsync();
//            await CheckLeagueAsync();
//            await CheckTypePlayAsync();
//        }

//        private async Task CheckRoles()
//        {
//            await _userHelper.CheckRoleAsync("Manager");
//            await _userHelper.CheckRoleAsync("Owner");
//            await _userHelper.CheckRoleAsync("Lessee");
//        }

//        private async Task<User> CheckUserAsync(
//            string firstName, 
//            string lastName, 
//            string email,
//            string phone, 
//            string address, 
//            string role)
//        {
//            var user = await _userHelper.GetUserByEmailAsync(email);
//            if (user == null)
//            {
//                user = new User
//                {
//                    FirstName = firstName,
//                    LastName = lastName,
//                    Email = email,
//                    UserName = "Enrique",
//                    PhoneNumber = phone,
//                    Address = address
//                };

//                await _userHelper.AddUserAsync(user, "123456");
//                await _userHelper.AddUserToRoleAsync(user, role);
//            }

//            return user;
//        }

//        private async Task CheckManagerAsync(User user)
//        {
//            if (!_context.Managers.Any())
//            {
//                _context.Managers.Add(new Manager { User = user });
//                await _context.SaveChangesAsync();
//            }
//        }

//        private async Task CheckLanguageAsync()
//        {
//            if (!_context.Languages.Any())
//            {
//                _context.Languages.Add(new Entities.Language { Name = "English", Status = true });
//                _context.Languages.Add(new Entities.Language { Name = "Spanish", Status = true });
//                await _context.SaveChangesAsync();
//            }
//        }

//        private async Task CheckLeagueAsync()
//        {
//            if (!_context.Leagues.Any())
//            {
//                _context.Leagues.Add(new Entities.League { Name = "Liga Dominicana de Béisbol", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Argentina Copa Argentina", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Argentina Primera División", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Baseball Players", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Belgium Jupiler League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Boxing League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Brazil Copa Do Brasil", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Brazil Serie A", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "CONCACAF Champions League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Canadian Football League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Caribbean Baseball League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Copa Libertadores", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Copa Sudamericana", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Coppa Italia", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "England", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "FIFA", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "FIFA Confederations Cup", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "France Coupe", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "France Ligue 1", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Germany Bundesliga", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Italy Serie A", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Liga Mexicana de Beisbol", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Liga Mexicana del Pacifico", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Liga Venezonala de Béisbol Profesional", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Major League Soccer", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Mexico Copa MX", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Mexico Primera División", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "NBA MatchUps", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "NBA Solo", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "NFL Solo", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "National Basketball Association", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "National College Basketball Association", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "National Collegiate Athletic Association Football", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "National Football League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Netherlands Eredivisie", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Portugal Primeira Liga", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Russia Premier League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Spain Copa del Rey", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Spain La Liga", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Turkey Super Lig", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Turkish Airlines Euroleague", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "UEFA Champion League", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "Womens National Basketball Association", Status = true });
//                _context.Leagues.Add(new Entities.League { Name = "World Cup", Status = true });
//                await _context.SaveChangesAsync();
//            }
//        }

//        private async Task CheckTypePlayAsync()
//        {
//            if (!_context.TypePlays.Any())
//            {
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera mitad a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en primera mitad a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en primera mitad a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego Completo", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Run Line", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Juego a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Equipo solo a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Equipo solo a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Super Run Line", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Pitcher ponches a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Pitcher ponches a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Run Line alternativo", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Sancocho(RHE) a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Sancocho(RHE) a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 equipo solo a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #1 equipo solo a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2 a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #2 a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3 a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #3 a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 equipo solo a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Periodo #4 equipo solo a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Segunda mitad a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en segunda mitad a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Solo en segunda mitad a menos", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia a mas", Status = true });
//                _context.TypePlays.Add(new Entities.TypePlay { Name = "Primera tercia a menos", Status = true });
//                await _context.SaveChangesAsync();
//            }
//        }
//    }
//}
