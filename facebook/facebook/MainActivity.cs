﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace facebook
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            List<Post> posts = new List<Post>
            {
                new Post
                {
                    Comments = new List<Comment>
                    {
                        new Comment { Name = "Jimmy Neutron", Text = "Suht lahe"}
                    },
                    Likes = 5,
                    Message = "Tere! Otsin paarilist kellega mängida minecrafti. Peab olema üle 7 aasta vana!!!",
                    Name = "Jaan Markus Jahilo",
                    Image = "minecraft"
                },
                new Post
                {
                    Likes = 235235,
                    Message = "Keegi kivi müüb v. Olop tõmbas minu oma ära",
                    Name = "Tom Kristian Abel"
                },
                new Post
                {
                    Comments = new List<Comment>
                    {
                        new Comment { Name = "Jimmy Neutron", Text = "Suht lahe"}
                    },
                    Likes = 74123436,
                    Message = "Hello World!",
                    Name = "Stefan",
                    Image = "dog"
                },
                new Post
                {
                    Comments = new List<Comment>
                    {
                        new Comment { Name = "Jimmy Neutron", Text = "Suht lahe"}
                    },
                    Likes = 63,
                    Message = "Hello World!",
                    Name = "Stefan",
                },
                new Post
                {
                    Comments = new List<Comment>
                    {
                        new Comment { Name = "Jimmy Neutron", Text = "Suht lahe"}
                    },
                    Likes = 7432,
                    Message = "Hello World!",
                    Name = "Stefan",
                    Image = "child"
                },
            };

            ListView listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new PostAdapter(this, posts);
        }
    }
}