﻿﻿//
// Copyright (c) 2012 Tim Heuer
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

using System;
using Windows.UI.Xaml;

namespace Callisto.Controls
{
    [Obsolete("Windows 8.1 now provides this functionality in the XAML framework itself as ToggleMenuFlyoutItem.")]
    public sealed class ToggleMenuItem : MenuItem
    {
        public ToggleMenuItem()
        {
            DefaultStyleKey = typeof(ToggleMenuItem);
        }

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(ToggleMenuItem), null);
    }
}
