﻿namespace Cake.Prca.PullRequests.Tfs
{
    using Issues;

    /// <summary>
    /// Class for providing the content for a pull request comment.
    /// </summary>
    internal static class ContentProvider
    {
        /// <summary>
        /// Returns the content for an issue.
        /// </summary>
        /// <param name="issue">Issue for which the content should be returned.</param>
        /// <returns>Comment content for the issue.</returns>
        public static string GetContent(ICodeAnalysisIssue issue)
        {
            var result = issue.Message;
            if (string.IsNullOrWhiteSpace(issue.Rule))
            {
                return result;
            }

            var ruleContent = issue.Rule;
            if (issue.RuleUrl != null)
            {
                ruleContent = $"[{issue.Rule}]({issue.RuleUrl})";
            }

            result = $"{ruleContent}: {result}";

            return result;
        }
    }
}
