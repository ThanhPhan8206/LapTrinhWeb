using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Models
{
    public class Book
    {
        public int Id { get; set; } //trả về id của sẩn phẩm
        public string Title { get; set; } //  trả về tên sách 
        public int AuthorId { get; set; } // trả về id của tác giả
        public int GenresId { get; set; } // trả về id của thể loại
        public string Image { get; set; } // trả về hình ảnh của sách 
        public float Price { get; set; }  // trả về giá của sách
        public int TotalPage { get; set; } // trả về tổng số trang của sách
        public string Summary { get; set; } // trả về tóm tắt nội dung của sách


        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "image/ChiPheo.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPage = 250
                 },

                new Book()
                {
                    Id = 2,
                    Title = "Dế Mèn Phiêu Lưu Ký",
                    AuthorId = 2,
                    GenresId = 1,
                    Image = "image/DeMen.jpg",
                    Price = 400000,
                    Summary = "",
                    TotalPage = 300
                },

                new Book()
                {
                    Id = 3,
                    Title = "Lão Hạc",
                    AuthorId = 3,
                    GenresId = 1,
                    Image = "image/LaoHac.jpg",
                    Price = 450000,
                    Summary = "",
                    TotalPage = 280
                },

                new Book()
                {
                    Id = 4,
                    Title = "Tắt Đèn",
                    AuthorId = 4,
                    GenresId = 1,
                    Image = "image/TatDen.jpg",
                    Price = 550000,
                    Summary = "",
                    TotalPage = 320
                }

            };

            return books;
        }


        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value ="1", Text="Nam Cao"},
            new SelectListItem { Value ="2", Text="Tô Hoài"},
            new SelectListItem { Value ="3", Text="Nam Cao"},
            new SelectListItem { Value ="4", Text="Ngô Tất Tố"},

        };

        public List<SelectListItem> Genres { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Truyện ngắn" },
            new SelectListItem { Value = "2", Text = "Truyện dài" },
            new SelectListItem { Value = "3", Text = "Thơ ca" },
            new SelectListItem { Value = "4", Text = "Tiểu thuyết" }
        };


    }
}
