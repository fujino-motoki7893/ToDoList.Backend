using Microsoft.EntityFrameworkCore;
using ToDoList.Backend.ToDoList.Domains.DTOs;
using ToDoList.Backend.ToDoList.Models.Entities;
using ToDoList.Backend.ToDoList.Common.CustomContext;
using ToDoList.Domains.DTOs;
using ToDoList.Models.DbContexts;

namespace ToDoList.Backend.ToDoList.Usecases
{
    /// <summary>
    /// アイテムのユースケースインターフェース
    /// </summary>
    public interface IItemUsecase
    {
        /// <summary>
        /// アイテムを追加する
        /// </summary>
        /// <param name="input">削除する検査結果の入力データ</param>
        /// <param name="context">アイテムを追加するためのコンテキスト</param>
        /// <returns>削除結果を含むペイロードを返すタスク</returns>
        Task<AddItemPayload> AddItemAsync(AddItemInput input, ApplicationDbContext context);
    }
}
