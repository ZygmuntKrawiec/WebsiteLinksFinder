WebsiteLinksFinder
==================

A simple app searches source code of the website to find all anchor tags and reads href value to find links.

Contains:
1. Windows Form 
  - textbox to write a web address to search,
  - a "find" button to run the app,
  - a listview to display all found values.
  
2. WebsiteContentReader class connects to website and reads source code.

3. WebsiteLinksFinder class searches all source code read by WebsiteContentReader, and finds links.

TODO:
  - URL verification to check.
  - Exeption handling. 
