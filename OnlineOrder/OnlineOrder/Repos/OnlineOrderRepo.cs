using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineOrder.Entities;

namespace OnlineOrder.Repos
{
    public class OnlineOrderRepo:IOnlineOrderRepo
    {
        IEnumerable<Category> IOnlineOrderRepo.GetAllCategory() => OnlineOrderManagement.Instance.GetAllCategory();
        public void AddCategory(Category category) => OnlineOrderManagement.Instance.AddCategory(category);
    }
}
