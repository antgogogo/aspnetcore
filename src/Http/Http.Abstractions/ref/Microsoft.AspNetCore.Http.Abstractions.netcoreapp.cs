// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Builder
{
    public abstract partial class EndpointBuilder
    {
        protected EndpointBuilder() { }
        public string DisplayName { get { throw null; } set { } }
        public System.Collections.Generic.IList<object> Metadata { get { throw null; } }
        public Microsoft.AspNetCore.Http.RequestDelegate RequestDelegate { get { throw null; } set { } }
        public abstract Microsoft.AspNetCore.Http.Endpoint Build();
    }
    public partial interface IApplicationBuilder
    {
        System.IServiceProvider ApplicationServices { get; set; }
        System.Collections.Generic.IDictionary<string, object> Properties { get; }
        Microsoft.AspNetCore.Http.Features.IFeatureCollection ServerFeatures { get; }
        Microsoft.AspNetCore.Http.RequestDelegate Build();
        Microsoft.AspNetCore.Builder.IApplicationBuilder New();
        Microsoft.AspNetCore.Builder.IApplicationBuilder Use(System.Func<Microsoft.AspNetCore.Http.RequestDelegate, Microsoft.AspNetCore.Http.RequestDelegate> middleware);
    }
    public partial interface IEndpointConventionBuilder
    {
        void Add(System.Action<Microsoft.AspNetCore.Builder.EndpointBuilder> convention);
    }
    public static partial class MapExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder Map(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Http.PathString pathMatch, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configuration) { throw null; }
    }
    public static partial class MapWhenExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder MapWhen(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Func<Microsoft.AspNetCore.Http.HttpContext, bool> predicate, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configuration) { throw null; }
    }
    public static partial class RunExtensions
    {
        public static void Run(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Http.RequestDelegate handler) { }
    }
    public static partial class UseExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder Use(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Func<Microsoft.AspNetCore.Http.HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware) { throw null; }
    }
    public static partial class UseMiddlewareExtensions
    {
        internal const string InvokeAsyncMethodName = "InvokeAsync";
        internal const string InvokeMethodName = "Invoke";
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseMiddleware(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Type middleware, params object[] args) { throw null; }
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseMiddleware<TMiddleware>(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, params object[] args) { throw null; }
    }
    public static partial class UsePathBaseExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UsePathBase(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, Microsoft.AspNetCore.Http.PathString pathBase) { throw null; }
    }
    public static partial class UseWhenExtensions
    {
        public static Microsoft.AspNetCore.Builder.IApplicationBuilder UseWhen(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, System.Func<Microsoft.AspNetCore.Http.HttpContext, bool> predicate, System.Action<Microsoft.AspNetCore.Builder.IApplicationBuilder> configuration) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Builder.Extensions
{
    public partial class MapMiddleware
    {
        public MapMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Builder.Extensions.MapOptions options) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class MapOptions
    {
        public MapOptions() { }
        public Microsoft.AspNetCore.Http.RequestDelegate Branch { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.PathString PathMatch { get { throw null; } set { } }
    }
    public partial class MapWhenMiddleware
    {
        public MapWhenMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Builder.Extensions.MapWhenOptions options) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
    public partial class MapWhenOptions
    {
        public MapWhenOptions() { }
        public Microsoft.AspNetCore.Http.RequestDelegate Branch { get { throw null; } set { } }
        public System.Func<Microsoft.AspNetCore.Http.HttpContext, bool> Predicate { get { throw null; } set { } }
    }
    public partial class UsePathBaseMiddleware
    {
        public UsePathBaseMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, Microsoft.AspNetCore.Http.PathString pathBase) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task Invoke(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Cors.Infrastructure
{
    public partial interface ICorsMetadata
    {
    }
}
namespace Microsoft.AspNetCore.Http
{
    public abstract partial class ConnectionInfo
    {
        protected ConnectionInfo() { }
        public abstract System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate { get; set; }
        public abstract string Id { get; set; }
        public abstract System.Net.IPAddress LocalIpAddress { get; set; }
        public abstract int LocalPort { get; set; }
        public abstract System.Net.IPAddress RemoteIpAddress { get; set; }
        public abstract int RemotePort { get; set; }
        public abstract System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial class CookieBuilder
    {
        internal static bool SuppressSameSiteNone;
        public CookieBuilder() { }
        public virtual string Domain { get { throw null; } set { } }
        public virtual System.TimeSpan? Expiration { get { throw null; } set { } }
        public virtual bool HttpOnly { get { throw null; } set { } }
        public virtual bool IsEssential { get { throw null; } set { } }
        public virtual System.TimeSpan? MaxAge { get { throw null; } set { } }
        public virtual string Name { get { throw null; } set { } }
        public virtual string Path { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Http.SameSiteMode SameSite { get { throw null; } set { } }
        public virtual Microsoft.AspNetCore.Http.CookieSecurePolicy SecurePolicy { get { throw null; } set { } }
        public Microsoft.AspNetCore.Http.CookieOptions Build(Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public virtual Microsoft.AspNetCore.Http.CookieOptions Build(Microsoft.AspNetCore.Http.HttpContext context, System.DateTimeOffset expiresFrom) { throw null; }
    }
    public enum CookieSecurePolicy
    {
        SameAsRequest = 0,
        Always = 1,
        None = 2,
    }
    public partial class Endpoint
    {
        public Endpoint(Microsoft.AspNetCore.Http.RequestDelegate requestDelegate, Microsoft.AspNetCore.Http.EndpointMetadataCollection metadata, string displayName) { }
        public string DisplayName { get { throw null; } }
        public Microsoft.AspNetCore.Http.EndpointMetadataCollection Metadata { get { throw null; } }
        public Microsoft.AspNetCore.Http.RequestDelegate RequestDelegate { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public static partial class EndpointHttpContextExtensions
    {
        public static Microsoft.AspNetCore.Http.Endpoint GetEndpoint(this Microsoft.AspNetCore.Http.HttpContext context) { throw null; }
        public static void SetEndpoint(this Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.Endpoint endpoint) { }
    }
    public sealed partial class EndpointMetadataCollection : System.Collections.Generic.IEnumerable<object>, System.Collections.Generic.IReadOnlyCollection<object>, System.Collections.Generic.IReadOnlyList<object>, System.Collections.IEnumerable
    {
        public static readonly Microsoft.AspNetCore.Http.EndpointMetadataCollection Empty;
        public EndpointMetadataCollection(System.Collections.Generic.IEnumerable<object> items) { }
        public EndpointMetadataCollection(params object[] items) { }
        public int Count { get { throw null; } }
        public object this[int index] { get { throw null; } }
        public Microsoft.AspNetCore.Http.EndpointMetadataCollection.Enumerator GetEnumerator() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public T GetMetadata<T>() where T : class { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public System.Collections.Generic.IReadOnlyList<T> GetOrderedMetadata<T>() where T : class { throw null; }
        System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            internal Enumerator(Microsoft.AspNetCore.Http.EndpointMetadataCollection collection) { throw null; }
            public object Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public readonly partial struct FragmentString : System.IEquatable<Microsoft.AspNetCore.Http.FragmentString>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Microsoft.AspNetCore.Http.FragmentString Empty;
        public FragmentString(string value) { throw null; }
        public bool HasValue { get { throw null; } }
        public string Value { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Http.FragmentString other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Http.FragmentString FromUriComponent(string uriComponent) { throw null; }
        public static Microsoft.AspNetCore.Http.FragmentString FromUriComponent(System.Uri uri) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.FragmentString left, Microsoft.AspNetCore.Http.FragmentString right) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.FragmentString left, Microsoft.AspNetCore.Http.FragmentString right) { throw null; }
        public override string ToString() { throw null; }
        public string ToUriComponent() { throw null; }
    }
    public static partial class HeaderDictionaryExtensions
    {
        public static void Append(this Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, Microsoft.Extensions.Primitives.StringValues value) { }
        public static void AppendCommaSeparatedValues(this Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, params string[] values) { }
        public static string[] GetCommaSeparatedValues(this Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key) { throw null; }
        public static void SetCommaSeparatedValues(this Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, params string[] values) { }
    }
    internal readonly partial struct HeaderSegment : System.IEquatable<Microsoft.AspNetCore.Http.HeaderSegment>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HeaderSegment(Microsoft.Extensions.Primitives.StringSegment formatting, Microsoft.Extensions.Primitives.StringSegment data) { throw null; }
        public Microsoft.Extensions.Primitives.StringSegment Data { get { throw null; } }
        public Microsoft.Extensions.Primitives.StringSegment Formatting { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Http.HeaderSegment other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.HeaderSegment left, Microsoft.AspNetCore.Http.HeaderSegment right) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.HeaderSegment left, Microsoft.AspNetCore.Http.HeaderSegment right) { throw null; }
    }
    internal readonly partial struct HeaderSegmentCollection : System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.HeaderSegment>, System.Collections.IEnumerable, System.IEquatable<Microsoft.AspNetCore.Http.HeaderSegmentCollection>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HeaderSegmentCollection(Microsoft.Extensions.Primitives.StringValues headers) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Http.HeaderSegmentCollection other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public Microsoft.AspNetCore.Http.HeaderSegmentCollection.Enumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.HeaderSegmentCollection left, Microsoft.AspNetCore.Http.HeaderSegmentCollection right) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.HeaderSegmentCollection left, Microsoft.AspNetCore.Http.HeaderSegmentCollection right) { throw null; }
        System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Http.HeaderSegment> System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Http.HeaderSegment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<Microsoft.AspNetCore.Http.HeaderSegment>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(Microsoft.Extensions.Primitives.StringValues headers) { throw null; }
            public Microsoft.AspNetCore.Http.HeaderSegment Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public readonly partial struct HostString : System.IEquatable<Microsoft.AspNetCore.Http.HostString>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HostString(string value) { throw null; }
        public HostString(string host, int port) { throw null; }
        public bool HasValue { get { throw null; } }
        public string Host { get { throw null; } }
        public int? Port { get { throw null; } }
        public string Value { get { throw null; } }
        public bool Equals(Microsoft.AspNetCore.Http.HostString other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Http.HostString FromUriComponent(string uriComponent) { throw null; }
        public static Microsoft.AspNetCore.Http.HostString FromUriComponent(System.Uri uri) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool MatchesAny(Microsoft.Extensions.Primitives.StringSegment value, System.Collections.Generic.IList<Microsoft.Extensions.Primitives.StringSegment> patterns) { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.HostString left, Microsoft.AspNetCore.Http.HostString right) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.HostString left, Microsoft.AspNetCore.Http.HostString right) { throw null; }
        public override string ToString() { throw null; }
        public string ToUriComponent() { throw null; }
    }
    internal partial class HostStringHelper
    {
        public HostStringHelper() { }
        public static bool IsSafeHostStringChar(char c) { throw null; }
    }
    public abstract partial class HttpContext
    {
        protected HttpContext() { }
        public abstract Microsoft.AspNetCore.Http.ConnectionInfo Connection { get; }
        public abstract Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { get; }
        public abstract System.Collections.Generic.IDictionary<object, object> Items { get; set; }
        public abstract Microsoft.AspNetCore.Http.HttpRequest Request { get; }
        public abstract System.Threading.CancellationToken RequestAborted { get; set; }
        public abstract System.IServiceProvider RequestServices { get; set; }
        public abstract Microsoft.AspNetCore.Http.HttpResponse Response { get; }
        public abstract Microsoft.AspNetCore.Http.ISession Session { get; set; }
        public abstract string TraceIdentifier { get; set; }
        public abstract System.Security.Claims.ClaimsPrincipal User { get; set; }
        public abstract Microsoft.AspNetCore.Http.WebSocketManager WebSockets { get; }
        public abstract void Abort();
    }
    public static partial class HttpMethods
    {
        public static readonly string Connect;
        public static readonly string Delete;
        public static readonly string Get;
        public static readonly string Head;
        public static readonly string Options;
        public static readonly string Patch;
        public static readonly string Post;
        public static readonly string Put;
        public static readonly string Trace;
        public static bool IsConnect(string method) { throw null; }
        public static bool IsDelete(string method) { throw null; }
        public static bool IsGet(string method) { throw null; }
        public static bool IsHead(string method) { throw null; }
        public static bool IsOptions(string method) { throw null; }
        public static bool IsPatch(string method) { throw null; }
        public static bool IsPost(string method) { throw null; }
        public static bool IsPut(string method) { throw null; }
        public static bool IsTrace(string method) { throw null; }
    }
    public abstract partial class HttpRequest
    {
        protected HttpRequest() { }
        public abstract System.IO.Stream Body { get; set; }
        public virtual System.IO.Pipelines.PipeReader BodyReader { get { throw null; } }
        public abstract long? ContentLength { get; set; }
        public abstract string ContentType { get; set; }
        public abstract Microsoft.AspNetCore.Http.IRequestCookieCollection Cookies { get; set; }
        public abstract Microsoft.AspNetCore.Http.IFormCollection Form { get; set; }
        public abstract bool HasFormContentType { get; }
        public abstract Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get; }
        public abstract Microsoft.AspNetCore.Http.HostString Host { get; set; }
        public abstract Microsoft.AspNetCore.Http.HttpContext HttpContext { get; }
        public abstract bool IsHttps { get; set; }
        public abstract string Method { get; set; }
        public abstract Microsoft.AspNetCore.Http.PathString Path { get; set; }
        public abstract Microsoft.AspNetCore.Http.PathString PathBase { get; set; }
        public abstract string Protocol { get; set; }
        public abstract Microsoft.AspNetCore.Http.IQueryCollection Query { get; set; }
        public abstract Microsoft.AspNetCore.Http.QueryString QueryString { get; set; }
        public virtual Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get { throw null; } set { } }
        public abstract string Scheme { get; set; }
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.IFormCollection> ReadFormAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public abstract partial class HttpResponse
    {
        protected HttpResponse() { }
        public abstract System.IO.Stream Body { get; set; }
        public virtual System.IO.Pipelines.PipeWriter BodyWriter { get { throw null; } }
        public abstract long? ContentLength { get; set; }
        public abstract string ContentType { get; set; }
        public abstract Microsoft.AspNetCore.Http.IResponseCookies Cookies { get; }
        public abstract bool HasStarted { get; }
        public abstract Microsoft.AspNetCore.Http.IHeaderDictionary Headers { get; }
        public abstract Microsoft.AspNetCore.Http.HttpContext HttpContext { get; }
        public abstract int StatusCode { get; set; }
        public virtual System.Threading.Tasks.Task CompleteAsync() { throw null; }
        public abstract void OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state);
        public virtual void OnCompleted(System.Func<System.Threading.Tasks.Task> callback) { }
        public abstract void OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state);
        public virtual void OnStarting(System.Func<System.Threading.Tasks.Task> callback) { }
        public virtual void Redirect(string location) { }
        public abstract void Redirect(string location, bool permanent);
        public virtual void RegisterForDispose(System.IDisposable disposable) { }
        public virtual void RegisterForDisposeAsync(System.IAsyncDisposable disposable) { }
        public virtual System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HttpResponseWritingExtensions
    {
        public static System.Threading.Tasks.Task WriteAsync(this Microsoft.AspNetCore.Http.HttpResponse response, string text, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task WriteAsync(this Microsoft.AspNetCore.Http.HttpResponse response, string text, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial interface IHttpContextAccessor
    {
        Microsoft.AspNetCore.Http.HttpContext HttpContext { get; set; }
    }
    public partial interface IHttpContextFactory
    {
        Microsoft.AspNetCore.Http.HttpContext Create(Microsoft.AspNetCore.Http.Features.IFeatureCollection featureCollection);
        void Dispose(Microsoft.AspNetCore.Http.HttpContext httpContext);
    }
    public partial interface IMiddleware
    {
        System.Threading.Tasks.Task InvokeAsync(Microsoft.AspNetCore.Http.HttpContext context, Microsoft.AspNetCore.Http.RequestDelegate next);
    }
    public partial interface IMiddlewareFactory
    {
        Microsoft.AspNetCore.Http.IMiddleware Create(System.Type middlewareType);
        void Release(Microsoft.AspNetCore.Http.IMiddleware middleware);
    }
    internal static partial class ParsingHelpers
    {
        public static void AppendHeaderJoined(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, params string[] values) { }
        public static void AppendHeaderUnmodified(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, Microsoft.Extensions.Primitives.StringValues values) { }
        public static Microsoft.Extensions.Primitives.StringValues GetHeader(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key) { throw null; }
        public static Microsoft.Extensions.Primitives.StringValues GetHeaderSplit(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key) { throw null; }
        public static Microsoft.Extensions.Primitives.StringValues GetHeaderUnmodified(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key) { throw null; }
        public static void SetHeaderJoined(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, Microsoft.Extensions.Primitives.StringValues value) { }
        public static void SetHeaderUnmodified(Microsoft.AspNetCore.Http.IHeaderDictionary headers, string key, Microsoft.Extensions.Primitives.StringValues? values) { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(Microsoft.AspNetCore.Http.PathStringConverter))]
    public readonly partial struct PathString : System.IEquatable<Microsoft.AspNetCore.Http.PathString>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Microsoft.AspNetCore.Http.PathString Empty;
        public PathString(string value) { throw null; }
        public bool HasValue { get { throw null; } }
        public string Value { get { throw null; } }
        public Microsoft.AspNetCore.Http.PathString Add(Microsoft.AspNetCore.Http.PathString other) { throw null; }
        public string Add(Microsoft.AspNetCore.Http.QueryString other) { throw null; }
        internal static Microsoft.AspNetCore.Http.PathString ConvertFromString(string s) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Http.PathString other) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Http.PathString other, System.StringComparison comparisonType) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Http.PathString FromUriComponent(string uriComponent) { throw null; }
        public static Microsoft.AspNetCore.Http.PathString FromUriComponent(System.Uri uri) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.AspNetCore.Http.PathString operator +(Microsoft.AspNetCore.Http.PathString left, Microsoft.AspNetCore.Http.PathString right) { throw null; }
        public static string operator +(Microsoft.AspNetCore.Http.PathString left, Microsoft.AspNetCore.Http.QueryString right) { throw null; }
        public static string operator +(Microsoft.AspNetCore.Http.PathString left, string right) { throw null; }
        public static string operator +(string left, Microsoft.AspNetCore.Http.PathString right) { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.PathString left, Microsoft.AspNetCore.Http.PathString right) { throw null; }
        public static implicit operator string (Microsoft.AspNetCore.Http.PathString path) { throw null; }
        public static implicit operator Microsoft.AspNetCore.Http.PathString (string s) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.PathString left, Microsoft.AspNetCore.Http.PathString right) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other, out Microsoft.AspNetCore.Http.PathString remaining) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other, out Microsoft.AspNetCore.Http.PathString matched, out Microsoft.AspNetCore.Http.PathString remaining) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other, System.StringComparison comparisonType) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other, System.StringComparison comparisonType, out Microsoft.AspNetCore.Http.PathString remaining) { throw null; }
        public bool StartsWithSegments(Microsoft.AspNetCore.Http.PathString other, System.StringComparison comparisonType, out Microsoft.AspNetCore.Http.PathString matched, out Microsoft.AspNetCore.Http.PathString remaining) { throw null; }
        public override string ToString() { throw null; }
        public string ToUriComponent() { throw null; }
    }
    internal sealed partial class PathStringConverter : System.ComponentModel.TypeConverter
    {
        public PathStringConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    internal static partial class PathStringHelper
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsPercentEncodedChar(string str, int index) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsValidPathChar(char c) { throw null; }
    }
    public readonly partial struct QueryString : System.IEquatable<Microsoft.AspNetCore.Http.QueryString>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Microsoft.AspNetCore.Http.QueryString Empty;
        public QueryString(string value) { throw null; }
        public bool HasValue { get { throw null; } }
        public string Value { get { throw null; } }
        public Microsoft.AspNetCore.Http.QueryString Add(Microsoft.AspNetCore.Http.QueryString other) { throw null; }
        public Microsoft.AspNetCore.Http.QueryString Add(string name, string value) { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString Create(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> parameters) { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString Create(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> parameters) { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString Create(string name, string value) { throw null; }
        public bool Equals(Microsoft.AspNetCore.Http.QueryString other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString FromUriComponent(string uriComponent) { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString FromUriComponent(System.Uri uri) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Microsoft.AspNetCore.Http.QueryString operator +(Microsoft.AspNetCore.Http.QueryString left, Microsoft.AspNetCore.Http.QueryString right) { throw null; }
        public static bool operator ==(Microsoft.AspNetCore.Http.QueryString left, Microsoft.AspNetCore.Http.QueryString right) { throw null; }
        public static bool operator !=(Microsoft.AspNetCore.Http.QueryString left, Microsoft.AspNetCore.Http.QueryString right) { throw null; }
        public override string ToString() { throw null; }
        public string ToUriComponent() { throw null; }
    }
    public delegate System.Threading.Tasks.Task RequestDelegate(Microsoft.AspNetCore.Http.HttpContext context);
    public static partial class RequestTrailerExtensions
    {
        public static bool CheckTrailersAvailable(this Microsoft.AspNetCore.Http.HttpRequest request) { throw null; }
        public static Microsoft.Extensions.Primitives.StringValues GetDeclaredTrailers(this Microsoft.AspNetCore.Http.HttpRequest request) { throw null; }
        public static Microsoft.Extensions.Primitives.StringValues GetTrailer(this Microsoft.AspNetCore.Http.HttpRequest request, string trailerName) { throw null; }
        public static bool SupportsTrailers(this Microsoft.AspNetCore.Http.HttpRequest request) { throw null; }
    }
    public static partial class ResponseTrailerExtensions
    {
        public static void AppendTrailer(this Microsoft.AspNetCore.Http.HttpResponse response, string trailerName, Microsoft.Extensions.Primitives.StringValues trailerValues) { }
        public static void DeclareTrailer(this Microsoft.AspNetCore.Http.HttpResponse response, string trailerName) { }
        public static bool SupportsTrailers(this Microsoft.AspNetCore.Http.HttpResponse response) { throw null; }
    }
    public static partial class StatusCodes
    {
        public const int Status100Continue = 100;
        public const int Status101SwitchingProtocols = 101;
        public const int Status102Processing = 102;
        public const int Status200OK = 200;
        public const int Status201Created = 201;
        public const int Status202Accepted = 202;
        public const int Status203NonAuthoritative = 203;
        public const int Status204NoContent = 204;
        public const int Status205ResetContent = 205;
        public const int Status206PartialContent = 206;
        public const int Status207MultiStatus = 207;
        public const int Status208AlreadyReported = 208;
        public const int Status226IMUsed = 226;
        public const int Status300MultipleChoices = 300;
        public const int Status301MovedPermanently = 301;
        public const int Status302Found = 302;
        public const int Status303SeeOther = 303;
        public const int Status304NotModified = 304;
        public const int Status305UseProxy = 305;
        public const int Status306SwitchProxy = 306;
        public const int Status307TemporaryRedirect = 307;
        public const int Status308PermanentRedirect = 308;
        public const int Status400BadRequest = 400;
        public const int Status401Unauthorized = 401;
        public const int Status402PaymentRequired = 402;
        public const int Status403Forbidden = 403;
        public const int Status404NotFound = 404;
        public const int Status405MethodNotAllowed = 405;
        public const int Status406NotAcceptable = 406;
        public const int Status407ProxyAuthenticationRequired = 407;
        public const int Status408RequestTimeout = 408;
        public const int Status409Conflict = 409;
        public const int Status410Gone = 410;
        public const int Status411LengthRequired = 411;
        public const int Status412PreconditionFailed = 412;
        public const int Status413PayloadTooLarge = 413;
        public const int Status413RequestEntityTooLarge = 413;
        public const int Status414RequestUriTooLong = 414;
        public const int Status414UriTooLong = 414;
        public const int Status415UnsupportedMediaType = 415;
        public const int Status416RangeNotSatisfiable = 416;
        public const int Status416RequestedRangeNotSatisfiable = 416;
        public const int Status417ExpectationFailed = 417;
        public const int Status418ImATeapot = 418;
        public const int Status419AuthenticationTimeout = 419;
        public const int Status421MisdirectedRequest = 421;
        public const int Status422UnprocessableEntity = 422;
        public const int Status423Locked = 423;
        public const int Status424FailedDependency = 424;
        public const int Status426UpgradeRequired = 426;
        public const int Status428PreconditionRequired = 428;
        public const int Status429TooManyRequests = 429;
        public const int Status431RequestHeaderFieldsTooLarge = 431;
        public const int Status451UnavailableForLegalReasons = 451;
        public const int Status500InternalServerError = 500;
        public const int Status501NotImplemented = 501;
        public const int Status502BadGateway = 502;
        public const int Status503ServiceUnavailable = 503;
        public const int Status504GatewayTimeout = 504;
        public const int Status505HttpVersionNotsupported = 505;
        public const int Status506VariantAlsoNegotiates = 506;
        public const int Status507InsufficientStorage = 507;
        public const int Status508LoopDetected = 508;
        public const int Status510NotExtended = 510;
        public const int Status511NetworkAuthenticationRequired = 511;
    }
    public abstract partial class WebSocketManager
    {
        protected WebSocketManager() { }
        public abstract bool IsWebSocketRequest { get; }
        public abstract System.Collections.Generic.IList<string> WebSocketRequestedProtocols { get; }
        public virtual System.Threading.Tasks.Task<System.Net.WebSockets.WebSocket> AcceptWebSocketAsync() { throw null; }
        public abstract System.Threading.Tasks.Task<System.Net.WebSockets.WebSocket> AcceptWebSocketAsync(string subProtocol);
    }
}
namespace Microsoft.AspNetCore.Http.Abstractions
{
    internal static partial class Resources
    {
        internal static string ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string Exception_InvokeDoesNotSupportRefOrOutParams { get { throw null; } }
        internal static string Exception_InvokeMiddlewareNoService { get { throw null; } }
        internal static string Exception_PathMustStartWithSlash { get { throw null; } }
        internal static string Exception_PortMustBeGreaterThanZero { get { throw null; } }
        internal static string Exception_UseMiddleMutlipleInvokes { get { throw null; } }
        internal static string Exception_UseMiddlewareExplicitArgumentsNotSupported { get { throw null; } }
        internal static string Exception_UseMiddlewareIServiceProviderNotAvailable { get { throw null; } }
        internal static string Exception_UseMiddlewareNoInvokeMethod { get { throw null; } }
        internal static string Exception_UseMiddlewareNoMiddlewareFactory { get { throw null; } }
        internal static string Exception_UseMiddlewareNonTaskReturnType { get { throw null; } }
        internal static string Exception_UseMiddlewareNoParameters { get { throw null; } }
        internal static string Exception_UseMiddlewareUnableToCreateMiddleware { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string RouteValueDictionary_DuplicateKey { get { throw null; } }
        internal static string RouteValueDictionary_DuplicatePropertyName { get { throw null; } }
        internal static string FormatException_InvokeDoesNotSupportRefOrOutParams(object p0) { throw null; }
        internal static string FormatException_InvokeMiddlewareNoService(object p0, object p1) { throw null; }
        internal static string FormatException_PathMustStartWithSlash(object p0) { throw null; }
        internal static string FormatException_UseMiddleMutlipleInvokes(object p0, object p1) { throw null; }
        internal static string FormatException_UseMiddlewareExplicitArgumentsNotSupported(object p0) { throw null; }
        internal static string FormatException_UseMiddlewareIServiceProviderNotAvailable(object p0) { throw null; }
        internal static string FormatException_UseMiddlewareNoInvokeMethod(object p0, object p1, object p2) { throw null; }
        internal static string FormatException_UseMiddlewareNoMiddlewareFactory(object p0) { throw null; }
        internal static string FormatException_UseMiddlewareNonTaskReturnType(object p0, object p1, object p2) { throw null; }
        internal static string FormatException_UseMiddlewareNoParameters(object p0, object p1, object p2) { throw null; }
        internal static string FormatException_UseMiddlewareUnableToCreateMiddleware(object p0, object p1) { throw null; }
        internal static string FormatRouteValueDictionary_DuplicateKey(object p0, object p1) { throw null; }
        internal static string FormatRouteValueDictionary_DuplicatePropertyName(object p0, object p1, object p2, object p3) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
namespace Microsoft.AspNetCore.Http.Features
{
    public partial interface IEndpointFeature
    {
        Microsoft.AspNetCore.Http.Endpoint Endpoint { get; set; }
    }
    public partial interface IRouteValuesFeature
    {
        Microsoft.AspNetCore.Routing.RouteValueDictionary RouteValues { get; set; }
    }
}
namespace Microsoft.AspNetCore.Routing
{
    public partial class RouteValueDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyDictionary<string, object>, System.Collections.IEnumerable
    {
        internal System.Collections.Generic.KeyValuePair<string, object>[] _arrayStorage;
        internal Microsoft.AspNetCore.Routing.RouteValueDictionary.PropertyStorage _propertyStorage;
        public RouteValueDictionary() { }
        public RouteValueDictionary(object values) { }
        public System.Collections.Generic.IEqualityComparer<string> Comparer { get { throw null; } }
        public int Count { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.IEnumerable<string> System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<object> System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.Values { get { throw null; } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool ContainsKey(string key) { throw null; }
        public static Microsoft.AspNetCore.Routing.RouteValueDictionary FromArray(System.Collections.Generic.KeyValuePair<string, object>[] items) { throw null; }
        public Microsoft.AspNetCore.Routing.RouteValueDictionary.Enumerator GetEnumerator() { throw null; }
        public bool Remove(string key) { throw null; }
        public bool Remove(string key, out object value) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> item) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryAdd(string key, object value) { throw null; }
        public bool TryGetValue(string key, out object value) { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public Enumerator(Microsoft.AspNetCore.Routing.RouteValueDictionary dictionary) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, object> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public bool MoveNext() { throw null; }
            public void Reset() { }
        }
        internal partial class PropertyStorage
        {
            public readonly Microsoft.Extensions.Internal.PropertyHelper[] Properties;
            public readonly object Value;
            public PropertyStorage(object value) { }
        }
    }
}
namespace Microsoft.Extensions.Internal
{
    internal static partial class ActivatorUtilities
    {
        public static Microsoft.Extensions.Internal.ObjectFactory CreateFactory(System.Type instanceType, System.Type[] argumentTypes) { throw null; }
        public static object CreateInstance(System.IServiceProvider provider, System.Type instanceType, params object[] parameters) { throw null; }
        public static T CreateInstance<T>(System.IServiceProvider provider, params object[] parameters) { throw null; }
        public static object GetServiceOrCreateInstance(System.IServiceProvider provider, System.Type type) { throw null; }
        public static T GetServiceOrCreateInstance<T>(System.IServiceProvider provider) { throw null; }
    }
    internal partial class ActivatorUtilitiesConstructorAttribute : System.Attribute
    {
        public ActivatorUtilitiesConstructorAttribute() { }
    }
    internal delegate object ObjectFactory(System.IServiceProvider serviceProvider, object[] arguments);
    internal partial class ParameterDefaultValue
    {
        public ParameterDefaultValue() { }
        public static bool TryGetDefaultValue(System.Reflection.ParameterInfo parameter, out object defaultValue) { throw null; }
    }
    internal partial class PropertyHelper
    {
        public PropertyHelper(System.Reflection.PropertyInfo property) { }
        public virtual string Name { get { throw null; } protected set { } }
        public System.Reflection.PropertyInfo Property { get { throw null; } }
        public System.Func<object, object> ValueGetter { get { throw null; } }
        public System.Action<object, object> ValueSetter { get { throw null; } }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Reflection.TypeInfo typeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Type type) { throw null; }
        protected static Microsoft.Extensions.Internal.PropertyHelper[] GetProperties(System.Type type, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyHelper> createPropertyHelper, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> cache) { throw null; }
        public object GetValue(object instance) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Reflection.TypeInfo typeInfo) { throw null; }
        public static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Type type) { throw null; }
        protected static Microsoft.Extensions.Internal.PropertyHelper[] GetVisibleProperties(System.Type type, System.Func<System.Reflection.PropertyInfo, Microsoft.Extensions.Internal.PropertyHelper> createPropertyHelper, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> allPropertiesCache, System.Collections.Concurrent.ConcurrentDictionary<System.Type, Microsoft.Extensions.Internal.PropertyHelper[]> visiblePropertiesCache) { throw null; }
        public static System.Func<object, object> MakeFastPropertyGetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Action<object, object> MakeFastPropertySetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Func<object, object> MakeNullSafeFastPropertyGetter(System.Reflection.PropertyInfo propertyInfo) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> ObjectToDictionary(object value) { throw null; }
        public void SetValue(object instance, object value) { }
    }
}
