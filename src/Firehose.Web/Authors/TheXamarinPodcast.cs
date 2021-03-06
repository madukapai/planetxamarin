﻿using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TheXamarinPodcast : IAmACommunityMember, IAmAPodcast
    {
        public string FirstName => "The Xamarin";

        public string LastName => "Podcast";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "hello@xamarin.com";

        public string ShortBioOrTagLine => "is the official Xamarin podcast discussing all things Xamarin!";

        public Uri WebSite => new Uri("https://soundcloud.com/xamarin-podcast");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feeds.soundcloud.com/users/soundcloud:users:55118534/sounds.rss"); }
        }

        public string TwitterHandle => "XamarinPodcast";

        public string GravatarHash => "70148d964bb389d42547834e1062c886";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => GeoPosition.Empty;
    }
}
