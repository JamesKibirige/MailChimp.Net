﻿using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum ConditionType
    {
        [Description("aim")]
        Aim,
        [Description("automation")]
        Automation,
        [Description("poll")]
        CampaignPoll,
        [Description("conversation")]
        Conversation,
        [Description("timestamp_opt")]
        Timestamp,
        [Description("info_changed")]
        InfoChanged,
        [Description("ecomm_date")]
        EcommDate,
        [Description("email_client")]
        EmailClient,
        [Description("language")]
        Language,
        [Description("rating")]
        MemberRating,
        [Description("source")]
        SignupSource,
        [Description("survey_monkey")]
        SurveyMonkey,
        [Description("gmonkey")]
        VIP,
        [Description("ecomm_cat")]
        EcommCategory,
        [Description("ecomm_prod")]
        EcommProduct,
        [Description("ecomm_spent_avg")]
        EcommSpentAverage,
        [Description("ecomm_orders")]
        EcommOrders,
        [Description("ecomm_prod_all")]
        EcommAllProducts,
        [Description("ecomm_avg_ord")]
        EcommAverageOrder,
        [Description("ecomm_purchased")]
        EcommPurchased,
        [Description("ecomm_spent_one")]
        EcommSpentOne,
        [Description("ecomm_spent_all")]
        EcommSpentAll,
        [Description("ecomm_store")]
        EcommStore,
        [Description("goal")]
        GoalActivity,
        [Description("goal_last_visited")]
        GoalTimestamp,
        [Description("fuzzy_segment")]
        FuzzySegment,
        [Description("static_segment")]
        StaticSegment,
        [Description("ipgeo")]
        IPGeo,
        [Description("social_age")]
        SocialAge,
        [Description("social_gender")]
        SocialGender,
        [Description("social_influence")]
        SocialInfluence,
        [Description("social_network")]
        SocialNetwork,        
        [Description("Date")]
        Date,
        [Description("Interests")]
        Interests,
        [Description("DateMerge")]
        DateMerge

    }
}