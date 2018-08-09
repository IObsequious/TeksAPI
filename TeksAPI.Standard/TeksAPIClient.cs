/*
 * TeksAPI.Standard
 *
 * This file was automatically generated for T.E.K.S. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using TEKS.Controllers;
using TEKS.Http.Client;
using TEKS.Utilities;

namespace TEKS
{
    public partial class TeksAPIClient
    {

        /// <summary>
        /// Singleton access to AssociationsManager controller
        /// </summary>
        public AssociationsManagerController AssociationsManager
        {
            get
            {
                return AssociationsManagerController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DefinitionsManager controller
        /// </summary>
        public DefinitionsManagerController DefinitionsManager
        {
            get
            {
                return DefinitionsManagerController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DocumentsManager controller
        /// </summary>
        public DocumentsManagerController DocumentsManager
        {
            get
            {
                return DocumentsManagerController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ItemsManager controller
        /// </summary>
        public ItemsManagerController ItemsManager
        {
            get
            {
                return ItemsManagerController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to PackagesManager controller
        /// </summary>
        public PackagesManagerController PackagesManager
        {
            get
            {
                return PackagesManagerController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to RubricsManager controller
        /// </summary>
        public RubricsManagerController RubricsManager
        {
            get
            {
                return RubricsManagerController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public TeksAPIClient() { }
        #endregion
    }
}