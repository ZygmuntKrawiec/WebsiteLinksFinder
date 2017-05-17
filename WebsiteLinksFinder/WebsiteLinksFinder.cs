using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebsiteLinksFinder
{
    /// <summary>
    /// Implements a finder that searches a string and finds all website links.
    /// </summary>
    class WebsiteLinksFinder
    {
        /// <summary>
        /// Searches a string and finds all website links. 
        /// </summary>
        /// <param name="content">Content to search.</param>
        /// <returns>Returns a list of found website links or null if content does not contain any links.</returns>
        public List<string> FindAllWebsiteLinks(string content)
        {
            // Read all website links from content and save it to the collection.
            MatchCollection matchLinks = Regex.Matches(content, "<a.*href=\"(.+?)\"", RegexOptions.Multiline);

            // if the collection of links has any link...
            if (matchLinks.Count != 0)
            {
                // Create a list of strings to keep links
                List<string> listOfLinks = new List<string>();

                // From the collection of links reads links one by one and add it to the list.
                foreach (Match match in matchLinks)
                    listOfLinks.Add(match.Groups[1].Value);
               
                // Return all links.
                return listOfLinks;
            }

            // If content does not have any link return null.
            return null;
        }
    }
}
