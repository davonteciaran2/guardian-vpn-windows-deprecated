﻿// <copyright file="UserFacingMessage.cs" company="Mozilla">
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, you can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace FirefoxPrivateNetwork.ErrorHandling
{
    /// <summary>
    /// User facing message element, used for displaying in-app toast messages.
    /// </summary>
    public class UserFacingMessage
    {
        private string messageId;
        private List<Type> decorations;
        private UserFacingMessage[] additionalMessages;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacingMessage"/> class.
        /// </summary>
        /// <param name="messageId">Message ID based on keys from the language files.</param>
        /// <param name="decorations">Decorations to add to the message (such as links and icons).</param>
        /// <param name="additionalMessages">Additional messages to show.</param>
        public UserFacingMessage(string messageId, List<Type> decorations = null, params UserFacingMessage[] additionalMessages)
        {
            Initialize(messageId, decorations, additionalMessages);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacingMessage"/> class.
        /// </summary>
        /// <param name="messageId">Message ID based on keys from the language files.</param>
        /// <param name="additionalMessages">Additional messages to show.</param>
        public UserFacingMessage(string messageId, params UserFacingMessage[] additionalMessages)
        {
            Initialize(messageId, null, additionalMessages);
        }

        /// <summary>
        /// Gets or sets the TextBlock element associated with this message.
        /// </summary>
        public TextBlock TextBlock { get; set; }

        /// <summary>
        /// Gets or sets the message contents associated with this message.
        /// </summary>
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Initialize a user facing toasst message by constructing a text block for later processing.
        /// </summary>
        /// <param name="messageId">Message ID based on keys from the language files.</param>
        /// <param name="decorations">Decorations to add to the message (such as links and icons).</param>
        /// <param name="additionalMessages">Additional messages to show.</param>
        private void Initialize(string messageId, List<Type> decorations, params UserFacingMessage[] additionalMessages)
        {
            this.messageId = messageId;
            this.decorations = decorations;
            this.additionalMessages = additionalMessages;
        }
    }
}
