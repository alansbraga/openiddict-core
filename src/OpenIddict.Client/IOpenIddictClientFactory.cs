﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/openiddict/openiddict-core for more information concerning
 * the license and the contributors participating to this project.
 */

using System.ComponentModel;

namespace OpenIddict.Client;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IOpenIddictClientFactory
{
    ValueTask<OpenIddictClientTransaction> CreateTransactionAsync();
}
