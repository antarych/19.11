using qwertyuiop.Filters;
using qwertyuiop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace qwertyuiop.Controllers
{
    [LoggingFilter]
    public class FilmController : ApiController
    {
        //public string GetUserFilms()
        //{
        //    return string.Format("User films");
        //}
        public string GetUserFilms(int id)
        {
            return string.Format("User {0} films", id);
        }

        //public Film[] GetUserFilms(int id)
        //{
        //    return new[] {
        //        new Film("Ip Man", "Donnie Yen", "Fighting"),
        //        new Film("Avatar", "James Cameron", "Action")
        //    };
        //}

        //public HttpResponseMessage GetUserFilms(int id)
        //{
        //    if (id == 10)
        //    {
        //        return Request.CreateErrorResponse(
        //            HttpStatusCode.NotFound,
        //            string.Format("User with id {0} not found", id));
        //    }

        //    return Request.CreateResponse(new[] {
        //        new Film("Ip Man", "Donnie Yen", "Fighting"),
        //        new Film("Avatar", "James Cameron", "Action")
        //    });
        //}
        [ModelValidationFilter]
        [ArgumentFiler]
        public HttpResponseMessage PostUserFilm(UserWatchedFilm userWatchedFilm)
        {
            return Request.CreateResponse(HttpStatusCode.Created, "Film was successfully added");
        }

        public HttpResponseMessage PostUserFilm([FromUri]int id, [FromBody]UserWatchedFilm userWatchedFilm)
        {
            return Request.CreateResponse(
                HttpStatusCode.Created,
                string.Format("Film for user {0} was successfully added", id));
        }
    }
}