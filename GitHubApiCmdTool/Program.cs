namespace GitHubApiCmdTool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using Octokit;

    class Program
    {
        static void Main(string[] args)
        {
            console_Start().Wait();
        }

        static async Task console_Start()
        {
            var user = await GetUser();

            Console.WriteLine(user.Followers + " folks love me!");
            Console.WriteLine("I love {0} folks!", user.Following);
        }

        static async Task<User> GetUser()
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHubApiCmdTool"));
            return await github.User.Get("colinnEx");
        }
    }
}
