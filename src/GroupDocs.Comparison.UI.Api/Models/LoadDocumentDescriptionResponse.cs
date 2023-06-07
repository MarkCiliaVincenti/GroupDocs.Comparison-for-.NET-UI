﻿using System.Text.Json.Serialization;

namespace GroupDocs.Comparison.UI.Api.Models
{
    public class LoadDocumentDescriptionResponse
    {
        /// <summary>
        /// File unique ID.
        /// </summary>
        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// File type e.g "docx".
        /// </summary>
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// Indicates if printing of the document is allowed.
        /// </summary>
        [JsonPropertyName("printAllowed")]
        public bool PrintAllowed { get; set; }

        /// <summary>
        /// Document pages.
        /// </summary>
        [JsonPropertyName("pages")]
        public List<PageDescription> Pages { get; set; }

        /// <summary>
        /// Search term from back to UI search after load document.
        /// </summary>
        [JsonPropertyName("searchTerm")]
        public string SearchTerm { get; set; }
    }
}