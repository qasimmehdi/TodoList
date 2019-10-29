using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync(){
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item3 = new TodoItem
            {
                Title = "Learn ASP.NET Core 3.0",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item4 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item5 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item6 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item7 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item8 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item9 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item10 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item11 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item12 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item13 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item84 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item14 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item15 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item16 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item17 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item18 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item19 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item20 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item21 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item85 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item22 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item23 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item24 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item25 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item26 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item27 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item28 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item29 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item30 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item31 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item32 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item33 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item34 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item35 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item36 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item37 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item38 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item39 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item40 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item41 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item42 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item43 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item44 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item45 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item46 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item47 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item49 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item50 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item51 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item52 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item53 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item54 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item55 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item56 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item57 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item58 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item59 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item60 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item61 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item62 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item63 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item64 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item65 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item66 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item67 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item68 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item69 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item70 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item71 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item72 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item73 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item74 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item75 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item76 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item77 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item78 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item79 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item80 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item81 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item82 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item83 = new TodoItem
            {
            Title = "Build awesome apps",
            DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] {item1,item2});
            //,item3,item4,item5,item6,item7,item8,item9,item10,item11,item12,item13,item14,item15,item16,item17,item18,item19,item20,item21,item22,item23,item24,item25,item26,item27,item28,item29,item30,item31,item32,item33,item34,item35,item36,item37,item38,item39,item40,item41,item42,item43,item44,item45,item46,item47,item49,item50,item51,item52,item53,item54,item55,item56,item57,item58,item59,item60,item61,item62,item63,item64,item65,item66,item67,item68,item69,item70,item71,item72,item73,item74,item75,item76,item77,item78,item79,item80,item81,item82,item83,item84,item85
        }
    }
}