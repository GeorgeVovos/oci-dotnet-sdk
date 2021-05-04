/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.AilanguageService.Requests;
using Oci.AilanguageService.Responses;

namespace Oci.AilanguageService
{
    /// <summary>Service client instance for AIServiceLanguage.</summary>
    public class AIServiceLanguageClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20210101";

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public AIServiceLanguageClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "AISERVICELANGUAGE",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://language.aiservice.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
        }

        /// <summary>
        /// Make a detect call to language detection pre-deployed model.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectDominantLanguage.cs.html">here</a> to see an example of how to use DetectDominantLanguage API.</example>
        public async Task<DetectDominantLanguageResponse> DetectDominantLanguage(DetectDominantLanguageRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called detectDominantLanguage");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/actions/detectDominantLanguage".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DetectDominantLanguageResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DetectDominantLanguage failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Make a detect call to enitiy pre-deployed model
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectLanguageEntities.cs.html">here</a> to see an example of how to use DetectLanguageEntities API.</example>
        public async Task<DetectLanguageEntitiesResponse> DetectLanguageEntities(DetectLanguageEntitiesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called detectLanguageEntities");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/actions/detectLanguageEntities".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DetectLanguageEntitiesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DetectLanguageEntities failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Make a detect call to the keyPhrase pre-deployed model.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectLanguageKeyPhrases.cs.html">here</a> to see an example of how to use DetectLanguageKeyPhrases API.</example>
        public async Task<DetectLanguageKeyPhrasesResponse> DetectLanguageKeyPhrases(DetectLanguageKeyPhrasesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called detectLanguageKeyPhrases");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/actions/detectLanguageKeyPhrases".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DetectLanguageKeyPhrasesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DetectLanguageKeyPhrases failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Make a detect call to sentiment pre-deployed model.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectLanguageSentiments.cs.html">here</a> to see an example of how to use DetectLanguageSentiments API.</example>
        public async Task<DetectLanguageSentimentsResponse> DetectLanguageSentiments(DetectLanguageSentimentsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called detectLanguageSentiments");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/actions/detectLanguageSentiments".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DetectLanguageSentimentsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DetectLanguageSentiments failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Make a detect call to text classification from the pre-deployed model.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectLanguageTextClassification.cs.html">here</a> to see an example of how to use DetectLanguageTextClassification API.</example>
        public async Task<DetectLanguageTextClassificationResponse> DetectLanguageTextClassification(DetectLanguageTextClassificationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called detectLanguageTextClassification");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/actions/detectLanguageTextClassification".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<DetectLanguageTextClassificationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DetectLanguageTextClassification failed with error: {e.Message}");
                throw;
            }
        }

    }
}
