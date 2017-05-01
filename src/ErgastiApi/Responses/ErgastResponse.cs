﻿using System;
using ErgastApi.Serialization;
using Newtonsoft.Json;

namespace ErgastApi.Responses
{
    public interface IErgastResponse
    {
        string Url { get; }

        int Limit { get; }

        int Offset { get; }

        int Total { get; }

        int Page { get; }

        int TotalPages { get; }

        bool HasMorePages { get; }
    }

    public class ErgastResponse : IErgastResponse
    {
        public string Url { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Total { get; set; }

        // TODO: Note that it can be inaccurate if limit/offset do not correlate
        // TODO: Test with 0 values
        public int Page => Offset / Limit;

        // TODO: Test with 0 values
        public int TotalPages => (int) Math.Ceiling(Total / (double)Limit);

        // TODO: Test
        public bool HasMorePages => Total > Limit + Offset;
    }
}