﻿using System;
using System.Net.Http;
using ErgastApi.Queries;

namespace ErgastApi.Requests
{
    public class ErgastRequestSettings
    {
        // TODO: Use by requests if not otherwise specified
        public static Func<ErgastRequestSettings> Defaults = () => new ErgastRequestSettings();

        private string _apiRoot = "http://ergast.com/api/f1";

        public string ApiRoot
        {
            get => _apiRoot;
            set
            {
                if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
                    throw new ArgumentException("Value is not a valid absolute URL");

                if (!value.StartsWith("http://") && !value.StartsWith("https://"))
                    throw new ArgumentException("Value is not a valid absolute URL");

                _apiRoot = value.TrimEnd('/');
            }
        }

        // TODO: Interface
        public HttpClient HttpClient { get; set; } = new HttpClient();

        public IQueryBuilder QueryBuilder { get; set; } = new QueryBuilder();
    }
}