﻿namespace WinUICommunity;
public static class Extensions
{
    public static SolidColorBrush GetSolidColorBrush(this string hex)
    {
        return ColorHelper.GetSolidColorBrush(hex);
    }
}
