using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebsiteLinksFinder
{
    /// <summary>
    /// Implements a reader that reads a web site content from 
    /// </summary>
    public class WebsiteContentReader
    {
        // PREPROC: Prevent to release before class is finished.
#if !DEBUG
            // Create a list of exceptions.
            var releaseExceptions = new List<Exception>();
#endif

        // Represents web site content
        string websiteContent = string.Empty;

        /// <summary>
        /// Returns the website content or the empty string if the website was not read.
        /// </summary>
        public string WebsiteContent { get { return websiteContent; } }

        /// <summary>
        /// Read a website content from a given path
        /// </summary>
        /// <param name="path">A path of the website</param>
        /// <returns>Returns "true" if the content was read, "false" if not.</returns>
        public bool ReadWebsiteContent(string path)
        {
            // Create a validator to check if path is a valid web address. 
            // TODO: Check if a way of validatnig address is correct.        
#if !DEBUG
            // Adds a new excetpion to check if validating is finished.
            releaseExceptions.Add(new Exception("Check if a way of validatnig address is correct.");
#endif
            // If path is not a valid address, then return false.
            if (!Uri.IsWellFormedUriString(path, UriKind.RelativeOrAbsolute))
            {
                return false;
            }

            // Create http client to read a content
            using (HttpClient httpClient = new HttpClient())
            {
                // TODO: Exceptions handling to redesign!!!!!.
#if !DEBUG
                // Adds a new exception to check if HttpClient exception handling is finished. 
                releaseExceptions.Add(new Exception("Redesign HttpClient exception handling.");
#endif
                // If the path does not contain http(s) schema.
                if (!Regex.IsMatch(path,"^https?://"))
                {
                    path = string.Format($"http://{path}");
                }

                try
                {
                    // Read content of the website
                    websiteContent = httpClient.GetAsync(path).Result.Content.ReadAsStringAsync().Result;
                }
                catch (ArgumentNullException)
                {
                    // TODO: Exception to handle in later time.
                    // If the exception happens, return false.
                    return false;

                }            
                catch (InvalidOperationException)
                {
                    // TODO: Exception to handle in later time.
                    // If the exception happens, return false.
                   return false;
                }               
                catch (AggregateException)
                {
                    // TODO: Exception to handle in later time.
                    // If the exception happens, return false.
                   return false;
                }
                catch (Exception)
                {
                    // TODO: Exception to handle in later time.
                    // If the exception happens, return false.
                    return false;
                }

                return true;
            }
        }
#if !DEBUG
        // If the list of exceptions is not empty then throw all exceptions.
        if(releaseExceptions.Count != 0)
        foreach(var exception in releaseExceptions)
        {
            throw exception;
        }
#endif
    }
}
