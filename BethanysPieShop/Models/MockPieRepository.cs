using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models {
    public class MockPieRepository : IPieRepository {
        private List<Pie> _pies;
        public MockPieRepository() {
            if (_pies == null) {
                InitializePies();
            }
        }

        private void InitializePies() {
            _pies = new List<Pie> {
                new Pie { Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "apple", LongDescription = "aaaaapppplllee", ImageUrl = "", ImageThumbnailUrl = "", IsPieOfTheWeek = true },
                new Pie { Id = 2, Name = "Blueberry Pie", Price = 112.95M, ShortDescription = "blueberry", LongDescription = "blueeeeberry", ImageUrl = "", ImageThumbnailUrl = "", IsPieOfTheWeek = true }
            };
        }

        public IEnumerable<Pie> GetAllPies() {
            return _pies;
        }

        public Pie GetPieById(int pieId) {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
