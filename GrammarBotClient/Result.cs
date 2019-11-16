using System;
using System.Collections.Generic;
using System.Text;

namespace GrammarBotClient
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public CheckContent CheckContent { get; set; }
    }

    public class CheckContent
    {
        public Software Software { get; set; }
        public Warnings Warnings { get; set; }
        public Language Language { get; set; }
        public List<Matches> Matches { get; set; }
    }

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public float ApiVersion { get; set; }
        public bool Premium { get; set; }
        public string PremiumHint { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return "Software [name=" + Name + ", version=" + Version + ", apiVersion=" + ApiVersion + ", premium=" + Premium
                    + ", premiumHint=" + PremiumHint + ", status=" + Status + "]";
        }
    }
    public class Warnings
    {
        public bool IncompleteResults { get; set; }
    }

    public class Matches
    {
        public string Message { get; set; }
        public string ShortMessage { get; set; }
        public List<Replacement> replacements = new List<Replacement>();
        public float offset { get; set; }
        public float Length { get; set; }
        public Context Context { get; set; }
        public string Sentence { get; set; }
        public Type Type { get; set; }
        public Rule Rule { get; set; }

        public override string ToString()
        {
            return "Matches [message=" + Message + ", shortMessage=" + ShortMessage + ", replacements=" + replacements
                    + ", offset=" + offset + ", length=" + Length + ", context=" + Context + ", sentence=" + Sentence
                    + ", typeObject=" + Type + ", rule=" + Rule + "]";
        }

    }

    public class Replacement
    {
        public string Value;
    }

    public class Context
    {
        public string Text { get; set; }
        public float Offset { get; set; }
        public float Length { get; set; }
    }

    public class Type
    {
        public string TypeName { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
        public string Code { get; set; }
        private DetectedLanguage DetectedLanguage { get; set; }
    }

    public class DetectedLanguage
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class Rule
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string IssueType { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}

