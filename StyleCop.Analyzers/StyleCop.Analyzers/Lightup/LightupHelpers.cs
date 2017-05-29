﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using System;
    using System.Linq;
    using Microsoft.CodeAnalysis.CSharp;

    internal static class LightupHelpers
    {
        public static bool SupportsCSharp7 { get; }
            = Enum.GetNames(typeof(SyntaxKind)).Contains(nameof(SyntaxKindEx.IsPatternExpression));
    }
}
