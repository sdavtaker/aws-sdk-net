/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.TranscribeService.Model;
using Amazon.TranscribeService.Model.Internal.MarshallTransformations;
using Amazon.TranscribeService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Implementation for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial class AmazonTranscribeServiceClient : AmazonServiceClient, IAmazonTranscribeService
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranscribeServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ITranscribeServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITranscribeServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TranscribeServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonTranscribeServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AmazonTranscribeServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials and an
        /// AmazonTranscribeServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, AmazonTranscribeServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateCallAnalyticsCategory

        /// <summary>
        /// Creates a call analytics category. Amazon Transcribe applies the conditions specified
        /// by your call analytics categories to your call analytics jobs. For each analytics
        /// category, you must create between 1 and 20 rules. For example, you can create a 'greeting'
        /// category with a rule that flags calls in which your agent does not use a specified
        /// phrase (for example: "Please note this call may be recorded.") in the first 15 seconds
        /// of the call. When you start a call analytics job, Amazon Transcribe applies all your
        /// existing call analytics categories to that job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        public virtual CreateCallAnalyticsCategoryResponse CreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<CreateCallAnalyticsCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCallAnalyticsCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        public virtual IAsyncResult BeginCreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCallAnalyticsCategory.</param>
        /// 
        /// <returns>Returns a  CreateCallAnalyticsCategoryResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        public virtual CreateCallAnalyticsCategoryResponse EndCreateCallAnalyticsCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCallAnalyticsCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLanguageModel

        /// <summary>
        /// Creates a new custom language model. When creating a new language model, you must
        /// specify if you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio
        /// sample rates under 16,000 Hz) base model. You then include the S3 URI location of
        /// your training and tuning files, the language for the model, a unique name, and any
        /// tags you want associated with your model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        public virtual CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLanguageModelResponseUnmarshaller.Instance;

            return Invoke<CreateLanguageModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        public virtual IAsyncResult BeginCreateLanguageModel(CreateLanguageModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLanguageModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLanguageModel.</param>
        /// 
        /// <returns>Returns a  CreateLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        public virtual CreateLanguageModelResponse EndCreateLanguageModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLanguageModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMedicalVocabulary

        /// <summary>
        /// Creates a new custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you must upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket. Note that this differs from
        /// , where you can include a list of terms within your request using the <code>Phrases</code>
        /// flag, as <code>CreateMedicalVocabulary</code> does not support the <code>Phrases</code>
        /// flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary text file, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        public virtual CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateMedicalVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        public virtual IAsyncResult BeginCreateMedicalVocabulary(CreateMedicalVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMedicalVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  CreateMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        public virtual CreateMedicalVocabularyResponse EndCreateMedicalVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMedicalVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVocabulary

        /// <summary>
        /// Creates a new custom vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you can either upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket or include a list of terms
        /// directly in your request using the <code>Phrases</code> flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual IAsyncResult BeginCreateVocabulary(CreateVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVocabulary.</param>
        /// 
        /// <returns>Returns a  CreateVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual CreateVocabularyResponse EndCreateVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVocabularyFilter

        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words from your transcription
        /// output. For example, you can use this operation to remove profanity from your transcript.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        public virtual CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateVocabularyFilter(CreateVocabularyFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  CreateVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        public virtual CreateVocabularyFilterResponse EndCreateVocabularyFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVocabularyFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCallAnalyticsCategory

        /// <summary>
        /// Deletes a call analytics category. To use this operation, specify the name of the
        /// category you want to delete using <code>CategoryName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        public virtual DeleteCallAnalyticsCategoryResponse DeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCallAnalyticsCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        public virtual IAsyncResult BeginDeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCallAnalyticsCategory.</param>
        /// 
        /// <returns>Returns a  DeleteCallAnalyticsCategoryResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        public virtual DeleteCallAnalyticsCategoryResponse EndDeleteCallAnalyticsCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCallAnalyticsCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCallAnalyticsJob

        /// <summary>
        /// Deletes a call analytics job. To use this operation, specify the name of the job you
        /// want to delete using <code>CallAnalyticsJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        public virtual DeleteCallAnalyticsJobResponse DeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCallAnalyticsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCallAnalyticsJob.</param>
        /// 
        /// <returns>Returns a  DeleteCallAnalyticsJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        public virtual DeleteCallAnalyticsJobResponse EndDeleteCallAnalyticsJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCallAnalyticsJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLanguageModel

        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <code>ModelName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        public virtual DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DeleteLanguageModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteLanguageModel(DeleteLanguageModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLanguageModel.</param>
        /// 
        /// <returns>Returns a  DeleteLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        public virtual DeleteLanguageModelResponse EndDeleteLanguageModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLanguageModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMedicalTranscriptionJob

        /// <summary>
        /// Deletes a medical transcription job, along with any related information. To use this
        /// operation, specify the name of the job you want to delete using <code>MedicalTranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        public virtual DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  DeleteMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        public virtual DeleteMedicalTranscriptionJobResponse EndDeleteMedicalTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMedicalTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMedicalVocabulary

        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// vocabulary you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        public virtual DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        public virtual IAsyncResult BeginDeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        public virtual DeleteMedicalVocabularyResponse EndDeleteMedicalVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMedicalVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTranscriptionJob

        /// <summary>
        /// Deletes a transcription job, along with any related information. To use this operation,
        /// specify the name of the job you want to delete using <code>TranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        public virtual DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteTranscriptionJob(DeleteTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  DeleteTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        public virtual DeleteTranscriptionJobResponse EndDeleteTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVocabulary

        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the vocabulary
        /// you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual IAsyncResult BeginDeleteVocabulary(DeleteVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual DeleteVocabularyResponse EndDeleteVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVocabularyFilter

        /// <summary>
        /// Deletes a vocabulary filter. To use this operation, specify the name of the vocabulary
        /// filter you want to delete using <code>VocabularyFilterName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        public virtual DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteVocabularyFilter(DeleteVocabularyFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  DeleteVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        public virtual DeleteVocabularyFilterResponse EndDeleteVocabularyFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVocabularyFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLanguageModel

        /// <summary>
        /// Provides information about a specific custom language model in your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation also shows if the base language model you used to create your custom
        /// language model has been updated. If Amazon Transcribe has updated the base model,
        /// you can create a new custom language model using the updated base model.
        /// </para>
        ///  
        /// <para>
        /// If you tried to create a new custom language model and the request wasn't successful,
        /// you can use this operation to help identify the reason. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        public virtual DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DescribeLanguageModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeLanguageModel(DescribeLanguageModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLanguageModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLanguageModel.</param>
        /// 
        /// <returns>Returns a  DescribeLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        public virtual DescribeLanguageModelResponse EndDescribeLanguageModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLanguageModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCallAnalyticsCategory

        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        public virtual GetCallAnalyticsCategoryResponse GetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCallAnalyticsCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        public virtual IAsyncResult BeginGetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCallAnalyticsCategory.</param>
        /// 
        /// <returns>Returns a  GetCallAnalyticsCategoryResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        public virtual GetCallAnalyticsCategoryResponse EndGetCallAnalyticsCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCallAnalyticsCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCallAnalyticsJob

        /// <summary>
        /// Retrieves information about a call analytics job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>CallAnalyticsJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field. If you
        /// enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears in the <code>RedactedTranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        public virtual GetCallAnalyticsJobResponse GetCallAnalyticsJob(GetCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCallAnalyticsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        public virtual IAsyncResult BeginGetCallAnalyticsJob(GetCallAnalyticsJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCallAnalyticsJob.</param>
        /// 
        /// <returns>Returns a  GetCallAnalyticsJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        public virtual GetCallAnalyticsJobResponse EndGetCallAnalyticsJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCallAnalyticsJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMedicalTranscriptionJob

        /// <summary>
        /// Retrieves information about a medical transcription job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>TranscriptionJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        public virtual GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetMedicalTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginGetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  GetMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        public virtual GetMedicalTranscriptionJobResponse EndGetMedicalTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMedicalTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMedicalVocabulary

        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        public virtual GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetMedicalVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        public virtual IAsyncResult BeginGetMedicalVocabulary(GetMedicalVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  GetMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        public virtual GetMedicalVocabularyResponse EndGetMedicalVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMedicalVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTranscriptionJob

        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginGetTranscriptionJob(GetTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  GetTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual GetTranscriptionJobResponse EndGetTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVocabulary

        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        public virtual GetVocabularyResponse GetVocabulary(GetVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        public virtual IAsyncResult BeginGetVocabulary(GetVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVocabulary.</param>
        /// 
        /// <returns>Returns a  GetVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        public virtual GetVocabularyResponse EndGetVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVocabularyFilter

        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        public virtual GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        public virtual IAsyncResult BeginGetVocabularyFilter(GetVocabularyFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  GetVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        public virtual GetVocabularyFilterResponse EndGetVocabularyFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVocabularyFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCallAnalyticsCategories

        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        public virtual ListCallAnalyticsCategoriesResponse ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCallAnalyticsCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCallAnalyticsCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        public virtual IAsyncResult BeginListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCallAnalyticsCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCallAnalyticsCategories.</param>
        /// 
        /// <returns>Returns a  ListCallAnalyticsCategoriesResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        public virtual ListCallAnalyticsCategoriesResponse EndListCallAnalyticsCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCallAnalyticsCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCallAnalyticsJobs

        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        public virtual ListCallAnalyticsJobsResponse ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsJobsResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCallAnalyticsJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCallAnalyticsJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        public virtual IAsyncResult BeginListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCallAnalyticsJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCallAnalyticsJobs.</param>
        /// 
        /// <returns>Returns a  ListCallAnalyticsJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        public virtual ListCallAnalyticsJobsResponse EndListCallAnalyticsJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCallAnalyticsJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLanguageModels

        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        public virtual ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguageModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguageModelsResponseUnmarshaller.Instance;

            return Invoke<ListLanguageModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLanguageModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLanguageModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        public virtual IAsyncResult BeginListLanguageModels(ListLanguageModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguageModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguageModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLanguageModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLanguageModels.</param>
        /// 
        /// <returns>Returns a  ListLanguageModelsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        public virtual ListLanguageModelsResponse EndListLanguageModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLanguageModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMedicalTranscriptionJobs

        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        public virtual ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListMedicalTranscriptionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMedicalTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMedicalTranscriptionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        public virtual IAsyncResult BeginListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalTranscriptionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMedicalTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMedicalTranscriptionJobs.</param>
        /// 
        /// <returns>Returns a  ListMedicalTranscriptionJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        public virtual ListMedicalTranscriptionJobsResponse EndListMedicalTranscriptionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMedicalTranscriptionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMedicalVocabularies

        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        public virtual ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListMedicalVocabulariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMedicalVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMedicalVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        public virtual IAsyncResult BeginListMedicalVocabularies(ListMedicalVocabulariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalVocabulariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMedicalVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMedicalVocabularies.</param>
        /// 
        /// <returns>Returns a  ListMedicalVocabulariesResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        public virtual ListMedicalVocabulariesResponse EndListMedicalVocabularies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMedicalVocabulariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTranscriptionJobs

        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTranscriptionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTranscriptionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual IAsyncResult BeginListTranscriptionJobs(ListTranscriptionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTranscriptionJobs.</param>
        /// 
        /// <returns>Returns a  ListTranscriptionJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual ListTranscriptionJobsResponse EndListTranscriptionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTranscriptionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVocabularies

        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        public virtual ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListVocabulariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        public virtual IAsyncResult BeginListVocabularies(ListVocabulariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabulariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVocabularies.</param>
        /// 
        /// <returns>Returns a  ListVocabulariesResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        public virtual ListVocabulariesResponse EndListVocabularies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVocabulariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVocabularyFilters

        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        public virtual ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabularyFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabularyFiltersResponseUnmarshaller.Instance;

            return Invoke<ListVocabularyFiltersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVocabularyFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVocabularyFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        public virtual IAsyncResult BeginListVocabularyFilters(ListVocabularyFiltersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabularyFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabularyFiltersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVocabularyFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVocabularyFilters.</param>
        /// 
        /// <returns>Returns a  ListVocabularyFiltersResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        public virtual ListVocabularyFiltersResponse EndListVocabularyFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVocabularyFiltersResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCallAnalyticsJob

        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        public virtual StartCallAnalyticsJobResponse StartCallAnalyticsJob(StartCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<StartCallAnalyticsJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCallAnalyticsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        public virtual IAsyncResult BeginStartCallAnalyticsJob(StartCallAnalyticsJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCallAnalyticsJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCallAnalyticsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCallAnalyticsJob.</param>
        /// 
        /// <returns>Returns a  StartCallAnalyticsJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        public virtual StartCallAnalyticsJobResponse EndStartCallAnalyticsJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCallAnalyticsJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMedicalTranscriptionJob

        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        public virtual StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartMedicalTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginStartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  StartMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        public virtual StartMedicalTranscriptionJobResponse EndStartMedicalTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMedicalTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTranscriptionJob

        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartTranscriptionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginStartTranscriptionJob(StartTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  StartTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual StartTranscriptionJobResponse EndStartTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags an Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCallAnalyticsCategory

        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        public virtual UpdateCallAnalyticsCategoryResponse UpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCallAnalyticsCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCallAnalyticsCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        public virtual IAsyncResult BeginUpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCallAnalyticsCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCallAnalyticsCategory.</param>
        /// 
        /// <returns>Returns a  UpdateCallAnalyticsCategoryResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        public virtual UpdateCallAnalyticsCategoryResponse EndUpdateCallAnalyticsCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCallAnalyticsCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMedicalVocabulary

        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        public virtual UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateMedicalVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        public virtual IAsyncResult BeginUpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMedicalVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  UpdateMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        public virtual UpdateMedicalVocabularyResponse EndUpdateMedicalVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMedicalVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVocabulary

        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        public virtual UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        public virtual IAsyncResult BeginUpdateVocabulary(UpdateVocabularyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVocabulary.</param>
        /// 
        /// <returns>Returns a  UpdateVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        public virtual UpdateVocabularyResponse EndUpdateVocabulary(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVocabularyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVocabularyFilter

        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        public virtual UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        public virtual IAsyncResult BeginUpdateVocabularyFilter(UpdateVocabularyFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  UpdateVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        public virtual UpdateVocabularyFilterResponse EndUpdateVocabularyFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVocabularyFilterResponse>(asyncResult);
        }

        #endregion
        
    }
}