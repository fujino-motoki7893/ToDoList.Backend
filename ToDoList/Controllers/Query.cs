using System.Linq;
using HotChocolate;
using ToDoList.Backend.ToDoList.Models.Entities;
using ToDoList.Models.DbContexts;

namespace ToDoList.Controllers
{
    /// <summary>
    /// クエリクラス
    /// </summary>
    public class Query
    {
        /// <summary>
        /// アイテムを取得するメソッド
        /// </summary>
        public IQueryable<Item> GetItems([Service] ApplicationDbContext context) =>
            context.Items;
    }
}
