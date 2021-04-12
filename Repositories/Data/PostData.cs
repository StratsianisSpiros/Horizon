using Entities.Models;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class PostData
    {
        private readonly List<Post> Posts = new List<Post>()
        {
            new Post() { PostId = 1, Content = "IMPORTANT NOTIFICATION: Tomorrow is the deadline for all the projects!",  PostDate = new DateTime(2020, 12, 10, 11, 30, 00), CompanyId = 1},
            new Post() { PostId = 2, Content = "https://www.theguardian.com/books/2018/dec/29/exclusive-sylvia-plath-extract-mary-ventura-and-the-ninth-kingdom", PostDate = new DateTime(2021, 01, 13, 20, 12, 00), CompanyId = 1},
            new Post() { PostId = 3, Content = "Meeting at 16:00 tomorrow morning", PostDate = new DateTime(2021, 03, 19, 17, 35, 00), CompanyId = 1},
            new Post() { PostId = 4, Content = "https://www.theguardian.com/books/2014/dec/15/robert-mcrum-100-best-novels-observer-steinbeck-grapes-wrath", PostDate = new DateTime(2021, 04, 25, 8, 35, 00), CompanyId = 1}

        };

        internal static List<Post> GetData() => new PostData().Posts;
    }
}
