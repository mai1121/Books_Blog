//DB接続用のクラス
using Microsoft.EntityFrameworkCore;
using Books_Blog.Models;
using System;

namespace Books_Blog.Data
{
    public class MvcBookContext:DbContext
    {
        //クラス継承している引数有りのコンストラクター定義　base必要
        public MvcBookContext(DbContextOptions<MvcBookContext>options)
            :base(options)
        {
        }
        //プロパティ
        public DbSet<Book> Book { get; set; }
    }
}
