using Microsoft.EntityFrameworkCore;
using ToDoList.Backend.ToDoList.Domains.DTOs;
using ToDoList.Backend.ToDoList.Models.Entities;
using ToDoList.Backend.ToDoList.Usecases;
using ToDoList.Domains.DTOs;
using ToDoList.Models.DbContexts;

namespace ToDoList.Backend.ToDoList.Controllers
{
    /// <summary>
    /// ミューテーションクラス
    /// </summary>
    public class Mutation
    {
        /// <summary>
        /// アイテムを追加するメソッド
        /// </summary>
        /// <param name="usecase">アイテムを扱うユースケース</param>
        /// <param name="input">アイテムを追加するインプット</param>
        /// <param name="context">アイテムを追加するためのコンテキスト</param>
        /// <returns>追加されたアイテム</returns>
        public async Task<AddItemPayload> AddItemAsync(
            [Service] IItemUsecase usecase,
            AddItemInput input,
            [Service] ApplicationDbContext context
        ) => await usecase.AddItemAsync(input, context);
    }
}
