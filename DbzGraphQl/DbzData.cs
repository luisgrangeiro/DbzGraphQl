using DbzGraphQl.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl
{
    public class DbzData
    {
        private readonly List<Earthman> _humans = new List<Earthman>();
        private readonly List<Saiyajin> _saiyajins = new List<Saiyajin>();

        public DbzData()
        {
            #region Character Data
            _humans.Add(new Earthman() {
                Id = "1",
                IsWarrior = true,
                Name = "Kuririn",
                Power = 5000,
                Enemies = new string[] { "Freeza","Android 17" }
            });

            _humans.Add(new Earthman() {
                Id = "2",
                Name = "Bulma",
                IsWarrior = false
            });

            _saiyajins.Add(new Saiyajin() {
                Id = "1",
                Name = "Goku",
                Power = 100000,
                SaiyajinLevel = 3,
                Enemies = new string[] { "Freeza","Cell","Majin Boo" }
            });

            _saiyajins.Add(new Saiyajin() {
                Id = "2",
                Name = "Vegeta",
                Power = 90000,
                SaiyajinLevel = 2,
                Enemies = new string[] { "Freeza","Cell","Majin Boo","Kakaroto" }
            });
            #endregion
        }

        public Task<Earthman> GetEarthmanByIdAsync(string id)
        {
            return Task.FromResult(_humans.FirstOrDefault(h => h.Id == id));
        }

        public Task<Saiyajin> GetSaiyajinByIdAsync(string id)
        {
            return Task.FromResult(_saiyajins.FirstOrDefault(h => h.Id == id));
        }
    }
}
