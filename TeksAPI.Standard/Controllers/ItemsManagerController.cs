/*
 * TeksAPI.Standard
 *
 * This file was automatically generated for T.E.K.S. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using TEKS;
using TEKS.Utilities;
using TEKS.Http.Request;
using TEKS.Http.Response;
using TEKS.Http.Client;
using TEKS.Exceptions;

namespace TEKS.Controllers
{
    public partial class ItemsManagerController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ItemsManagerController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ItemsManagerController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ItemsManagerController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This is a request to the Service Provider to provide the specified Competency Framework Item.  If the identified record cannot be found then the 'unknownobject' status code must be reported.
        /// </summary>
        /// <param name="sourcedId">Required parameter: The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <return>Returns the Models.CFItem response from the API call</return>
        public Models.CFItem GetCFItem(string sourcedId)
        {
            Task<Models.CFItem> t = GetCFItemAsync(sourcedId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This is a request to the Service Provider to provide the specified Competency Framework Item.  If the identified record cannot be found then the 'unknownobject' status code must be reported.
        /// </summary>
        /// <param name="sourcedId">Required parameter: The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <return>Returns the Models.CFItem response from the API call</return>
        public async Task<Models.CFItem> GetCFItemAsync(string sourcedId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/CFItems/{sourcedId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "sourcedId", sourcedId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ImsxStatusInfoException(@"An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'.", _context);

            if (_response.StatusCode == 401)
                throw new ImsxStatusInfoException(@"The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.", _context);

            if (_response.StatusCode == 403)
                throw new ImsxStatusInfoException(@"This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.", _context);

            if (_response.StatusCode == 404)
                throw new ImsxStatusInfoException(@"Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented.", _context);

            if (_response.StatusCode == 429)
                throw new ImsxStatusInfoException(@"The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.", _context);

            if (_response.StatusCode == 500)
                throw new ImsxStatusInfoException(@"This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.", _context);

            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new ImsxStatusInfoException(@"This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.CFItem>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 