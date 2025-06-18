// Replace the placeholders with your own values
using Microsoft.Extensions.Configuration;
using WebModerator;
using WebModerator.Enums;
using WebModerator.Models;

IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
IConfigurationRoot configuration = builder.Build();
var AiSvcEndpoint = configuration["AIServicesEndpoint"];
var AiSvCKey = configuration["AIServicesKey"];

// Initialize the ContentSafety object
ContentSafety contentSafety = new ContentSafety(AiSvcEndpoint, AiSvCKey);

// Set the media type and blocklists
MediaType mediaType = MediaType.Image;
string[] blocklists = { };

// Set the base64 image
string content = "";

// Detect content safety
DetectionResult detectionResult = await contentSafety.Detect(mediaType, content, blocklists);

// Set the reject thresholds for each category
Dictionary<Category, int> rejectThresholds = new Dictionary<Category, int> {
                { Category.Hate, 4 }, { Category.SelfHarm, 4 }, { Category.Sexual, 4 }, { Category.Violence, 4 }
            };

// Make a decision based on the detection result and reject thresholds
Decision decisionResult = contentSafety.MakeDecision(detectionResult, rejectThresholds);