﻿using MongoDB.Bson;
using System;
namespace WebApplication1.Models
{
    public class PhotoModel
    {
        //private const string PHOTO_URL = "http://localhost:5000/Photos/";
        private const string PHOTO_URL = "https://bildarchivaarau.azurewebsites.net/photos/";

        public ObjectId Id { get; set; }
        public int PhotoId { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        public int Height { get; set; }
        public string Filename { get; set; }
        public int Width { get; set; }
        public string Link { get { return PHOTO_URL + Filename; } }
    }
}