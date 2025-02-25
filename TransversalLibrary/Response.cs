﻿using System;
using System.Collections.Generic;
using System.Net;

namespace TransversalLibrary
{
    /// <summary>
    /// Define el response de la función
    /// </summary>
    /// <typeparam name="T">Define el tipo genérico</typeparam>
    public class Response<T>
    {
        #region HTTP STATUS CODE

        /// <summary>
        /// Define el código de estado Http
        /// </summary>
        private HttpStatusCode? _HttpStatusCode = System.Net.HttpStatusCode.OK;

        /// <summary>
        /// Obtiene o establece el código de estado Http
        /// </summary>
        public HttpStatusCode? HttpStatusCode
        {
            get
            {
                return _HttpStatusCode;
            }
            set
            {
                _HttpStatusCode = value;
            }
        }

        #endregion

        #region DATA

        /// <summary>
        /// Define el objeto de respuesta
        /// </summary>
        private T _Data = default(T);

        /// <summary>
        /// Obtiene o establece el objeto de respuesta
        /// </summary>
        public T Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
            }
        }

        #endregion

        #region EXCEPTION

        /// <summary>
        /// Obtiene o establece la excepción
        /// </summary>
        public Exception Exception { get; set; }

        #endregion

        #region ERRORS

        /// <summary>
        /// Obtiene los errores
        /// </summary>
        public List<string> Errors { get; } = new List<string>();

        #endregion
    }
}