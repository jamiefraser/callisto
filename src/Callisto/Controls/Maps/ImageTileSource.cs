﻿// Copyright (c) 2013 Tim Heuer
// Derivitive work from:
//      XAML Map Control - http://xamlmapcontrol.codeplex.com/
//      Copyright © Clemens Fischer 2012-2013
//
// Licensed under the Microsoft Public License (Ms-PL) (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Callisto.Controls
{
    /// <summary>
    /// Provides the image of a map tile. ImageTileSource bypasses downloading and
    /// optional caching in TileImageLoader. By overriding the LoadImage method,
    /// an application can provide tile images from an arbitrary source.
    /// WPF only: If the CanLoadAsync property is true, LoadImage will be called
    /// from a separate, non-UI thread and must hence return a frozen ImageSource.
    /// </summary>
    public class ImageTileSource : TileSource
    {
        public virtual ImageSource LoadImage(int x, int y, int zoomLevel)
        {
            var uri = GetUri(x, y, zoomLevel);

            return uri != null ? new BitmapImage(uri) : null;
        }
    }
}