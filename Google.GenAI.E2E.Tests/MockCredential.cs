/*
 * Copyright 2025 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;

/// <summary>
/// Mock credential for E2E tests in replay mode.
/// Returns a static fake access token without making any network calls.
/// </summary>
public class MockCredential : ICredential
{
    private const string FakeAccessToken = "fake-access-token-for-replay-mode";

    public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(FakeAccessToken);
    }

    public void Initialize(Google.Apis.Http.ConfigurableHttpClient httpClient)
    {
        // No initialization needed for mock credential
    }
}
