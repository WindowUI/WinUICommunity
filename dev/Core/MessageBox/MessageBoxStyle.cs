﻿namespace WinUICommunity;

[Flags]
public enum MessageBoxStyle
{
    None = 0,
    AbortRetryIgnore = 1 << 0,
    ApplicationModal = 1 << 1,
    CancelTryAgainContinue = 1 << 2,
    DefaultDesktopOnly = 1 << 3,
    DefualtButton1 = 1 << 4,
    DefualtButton2 = 1 << 5,
    DefualtButton3 = 1 << 6,
    DefualtButton4 = 1 << 7,
    DefualtMask = 1 << 8,
    Help = 1 << 9,
    IconAsterisk = 1 << 10,
    IconError = 1 << 11,
    IconExclamation = 1 << 12,
    IconHand = 1 << 13,
    IconInformation = 1 << 14,
    IconMask = 1 << 15,
    IconQuestion = 1 << 16,
    IconStop = 1 << 17,
    IconWarning = 1 << 18,
    MiscMask = 1 << 19,
    ModeMask = 1 << 20,
    NoFocus = 1 << 21,
    Ok = 1 << 22,
    OkCancel = 1 << 23,
    RetryCancel = 1 << 24,
    Right = 1 << 25,
    RtlReading = 1 << 26,
    ServiceNotification = 1 << 27,
    ServiceNotificationNT3X = 1 << 28,
    SetForeground = 1 << 29,
    SystemModal = 1 << 30,
    TaskModal = 1 << 31,
    Topmost = 1 << 32,
    TypeMask = 1 << 33,
    UserIcon = 1 << 34,
    YesNo = 1 << 35,
    YesNoCancel = 1 << 36
}
