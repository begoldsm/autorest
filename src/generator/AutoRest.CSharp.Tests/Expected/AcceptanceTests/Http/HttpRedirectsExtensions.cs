// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HttpRedirects.
    /// </summary>
    public static partial class HttpRedirectsExtensions
    {
            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsHead300Headers Head300(this IHttpRedirects operations)
            {
                return operations.Head300Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsHead300Headers> Head300Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Head300WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> Get300(this IHttpRedirects operations)
            {
                return operations.Get300Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> Get300Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get300WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsHead301Headers Head301(this IHttpRedirects operations)
            {
                return operations.Head301Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsHead301Headers> Head301Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Head301WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsGet301Headers Get301(this IHttpRedirects operations)
            {
                return operations.Get301Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsGet301Headers> Get301Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get301WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Put true Boolean value in request returns 301.  This request should not be
            /// automatically redirected, but should return the received 301 to the caller
            /// for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPut301Headers Put301(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Put301Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put true Boolean value in request returns 301.  This request should not be
            /// automatically redirected, but should return the received 301 to the caller
            /// for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPut301Headers> Put301Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Put301WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsHead302Headers Head302(this IHttpRedirects operations)
            {
                return operations.Head302Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsHead302Headers> Head302Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Head302WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsGet302Headers Get302(this IHttpRedirects operations)
            {
                return operations.Get302Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsGet302Headers> Get302Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get302WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Patch true Boolean value in request returns 302.  This request should not
            /// be automatically redirected, but should return the received 302 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPatch302Headers Patch302(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Patch302Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch true Boolean value in request returns 302.  This request should not
            /// be automatically redirected, but should return the received 302 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPatch302Headers> Patch302Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Patch302WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Post true Boolean value in request returns 303.  This request should be
            /// automatically redirected usign a get, ultimately returning a 200 status
            /// code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPost303Headers Post303(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Post303Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post true Boolean value in request returns 303.  This request should be
            /// automatically redirected usign a get, ultimately returning a 200 status
            /// code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPost303Headers> Post303Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post303WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Redirect with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsHead307Headers Head307(this IHttpRedirects operations)
            {
                return operations.Head307Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redirect with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsHead307Headers> Head307Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Head307WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Redirect get with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HttpRedirectsGet307Headers Get307(this IHttpRedirects operations)
            {
                return operations.Get307Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redirect get with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsGet307Headers> Get307Async(this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get307WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Put redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPut307Headers Put307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Put307Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPut307Headers> Put307Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Put307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Patch redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPatch307Headers Patch307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Patch307Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPatch307Headers> Patch307Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Patch307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Post redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsPost307Headers Post307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Post307Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsPost307Headers> Post307Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Delete redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static HttpRedirectsDelete307Headers Delete307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                return operations.Delete307Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HttpRedirectsDelete307Headers> Delete307Async(this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Delete307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
