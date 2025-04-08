using ToDoList.Backend.ToDoList.Models.Entities;

namespace ToDoList.Backend.ToDoList.Common.CustomContext
{
    /// <summary>
    /// アプリケーションコンテキストクラス
    /// </summary>
    public class ApplicationContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="items">アイテムのリスト</param>
        public ApplicationContext(IQueryable<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// アイテムのリスト
        /// </summary>
        public IQueryable<Item> Items { get; }
    }
}
