// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class JiraNotificationArgs extends com.pulumi.resources.ResourceArgs {

    public static final JiraNotificationArgs Empty = new JiraNotificationArgs();

    /**
     * The configuration is enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="active", required=true)
    private Output<Boolean> active;

    /**
     * @return The configuration is enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Boolean> active() {
        return this.active;
    }

    /**
     * The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
     * 
     */
    @Import(name="apiToken")
    private @Nullable Output<String> apiToken;

    /**
     * @return The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
     * 
     */
    public Optional<Output<String>> apiToken() {
        return Optional.ofNullable(this.apiToken);
    }

    /**
     * The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
     * 
     */
    @Import(name="description", required=true)
    private Output<String> description;

    /**
     * @return The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
     * 
     */
    public Output<String> description() {
        return this.description;
    }

    /**
     * The type of the Jira issue to be created by this notification
     * 
     */
    @Import(name="issueType", required=true)
    private Output<String> issueType;

    /**
     * @return The type of the Jira issue to be created by this notification
     * 
     */
    public Output<String> issueType() {
        return this.issueType;
    }

    /**
     * The ID of these settings when referred to from resources requiring the REST API V1 keys
     * 
     */
    @Import(name="legacyId")
    private @Nullable Output<String> legacyId;

    /**
     * @return The ID of these settings when referred to from resources requiring the REST API V1 keys
     * 
     */
    public Optional<Output<String>> legacyId() {
        return Optional.ofNullable(this.legacyId);
    }

    /**
     * The name of the notification configuration
     * 
     */
    @Import(name="name")
    private @Nullable Output<String> name;

    /**
     * @return The name of the notification configuration
     * 
     */
    public Optional<Output<String>> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * The ID of the associated alerting profile
     * 
     */
    @Import(name="profile", required=true)
    private Output<String> profile;

    /**
     * @return The ID of the associated alerting profile
     * 
     */
    public Output<String> profile() {
        return this.profile;
    }

    /**
     * The project key of the Jira issue to be created by this notification
     * 
     */
    @Import(name="projectKey", required=true)
    private Output<String> projectKey;

    /**
     * @return The project key of the Jira issue to be created by this notification
     * 
     */
    public Output<String> projectKey() {
        return this.projectKey;
    }

    /**
     * The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
     * 
     */
    @Import(name="summary", required=true)
    private Output<String> summary;

    /**
     * @return The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
     * 
     */
    public Output<String> summary() {
        return this.summary;
    }

    /**
     * The URL of the Jira API endpoint
     * 
     */
    @Import(name="url", required=true)
    private Output<String> url;

    /**
     * @return The URL of the Jira API endpoint
     * 
     */
    public Output<String> url() {
        return this.url;
    }

    /**
     * The username of the Jira profile
     * 
     */
    @Import(name="username", required=true)
    private Output<String> username;

    /**
     * @return The username of the Jira profile
     * 
     */
    public Output<String> username() {
        return this.username;
    }

    private JiraNotificationArgs() {}

    private JiraNotificationArgs(JiraNotificationArgs $) {
        this.active = $.active;
        this.apiToken = $.apiToken;
        this.description = $.description;
        this.issueType = $.issueType;
        this.legacyId = $.legacyId;
        this.name = $.name;
        this.profile = $.profile;
        this.projectKey = $.projectKey;
        this.summary = $.summary;
        this.url = $.url;
        this.username = $.username;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(JiraNotificationArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private JiraNotificationArgs $;

        public Builder() {
            $ = new JiraNotificationArgs();
        }

        public Builder(JiraNotificationArgs defaults) {
            $ = new JiraNotificationArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param active The configuration is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder active(Output<Boolean> active) {
            $.active = active;
            return this;
        }

        /**
         * @param active The configuration is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder active(Boolean active) {
            return active(Output.of(active));
        }

        /**
         * @param apiToken The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
         * 
         * @return builder
         * 
         */
        public Builder apiToken(@Nullable Output<String> apiToken) {
            $.apiToken = apiToken;
            return this;
        }

        /**
         * @param apiToken The API token for the Jira profile. Using password authentication [was deprecated by Jira](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-basic-auth-and-cookie-based-auth/)
         * 
         * @return builder
         * 
         */
        public Builder apiToken(String apiToken) {
            return apiToken(Output.of(apiToken));
        }

        /**
         * @param description The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
         * 
         * @return builder
         * 
         */
        public Builder description(Output<String> description) {
            $.description = description;
            return this;
        }

        /**
         * @param description The description of the Jira issue to be created by this notification.   You can use same placeholders as in issue summary
         * 
         * @return builder
         * 
         */
        public Builder description(String description) {
            return description(Output.of(description));
        }

        /**
         * @param issueType The type of the Jira issue to be created by this notification
         * 
         * @return builder
         * 
         */
        public Builder issueType(Output<String> issueType) {
            $.issueType = issueType;
            return this;
        }

        /**
         * @param issueType The type of the Jira issue to be created by this notification
         * 
         * @return builder
         * 
         */
        public Builder issueType(String issueType) {
            return issueType(Output.of(issueType));
        }

        /**
         * @param legacyId The ID of these settings when referred to from resources requiring the REST API V1 keys
         * 
         * @return builder
         * 
         */
        public Builder legacyId(@Nullable Output<String> legacyId) {
            $.legacyId = legacyId;
            return this;
        }

        /**
         * @param legacyId The ID of these settings when referred to from resources requiring the REST API V1 keys
         * 
         * @return builder
         * 
         */
        public Builder legacyId(String legacyId) {
            return legacyId(Output.of(legacyId));
        }

        /**
         * @param name The name of the notification configuration
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable Output<String> name) {
            $.name = name;
            return this;
        }

        /**
         * @param name The name of the notification configuration
         * 
         * @return builder
         * 
         */
        public Builder name(String name) {
            return name(Output.of(name));
        }

        /**
         * @param profile The ID of the associated alerting profile
         * 
         * @return builder
         * 
         */
        public Builder profile(Output<String> profile) {
            $.profile = profile;
            return this;
        }

        /**
         * @param profile The ID of the associated alerting profile
         * 
         * @return builder
         * 
         */
        public Builder profile(String profile) {
            return profile(Output.of(profile));
        }

        /**
         * @param projectKey The project key of the Jira issue to be created by this notification
         * 
         * @return builder
         * 
         */
        public Builder projectKey(Output<String> projectKey) {
            $.projectKey = projectKey;
            return this;
        }

        /**
         * @param projectKey The project key of the Jira issue to be created by this notification
         * 
         * @return builder
         * 
         */
        public Builder projectKey(String projectKey) {
            return projectKey(Output.of(projectKey));
        }

        /**
         * @param summary The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
         * 
         * @return builder
         * 
         */
        public Builder summary(Output<String> summary) {
            $.summary = summary;
            return this;
        }

        /**
         * @param summary The summary of the Jira issue to be created by this notification.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
         * 
         * @return builder
         * 
         */
        public Builder summary(String summary) {
            return summary(Output.of(summary));
        }

        /**
         * @param url The URL of the Jira API endpoint
         * 
         * @return builder
         * 
         */
        public Builder url(Output<String> url) {
            $.url = url;
            return this;
        }

        /**
         * @param url The URL of the Jira API endpoint
         * 
         * @return builder
         * 
         */
        public Builder url(String url) {
            return url(Output.of(url));
        }

        /**
         * @param username The username of the Jira profile
         * 
         * @return builder
         * 
         */
        public Builder username(Output<String> username) {
            $.username = username;
            return this;
        }

        /**
         * @param username The username of the Jira profile
         * 
         * @return builder
         * 
         */
        public Builder username(String username) {
            return username(Output.of(username));
        }

        public JiraNotificationArgs build() {
            $.active = Objects.requireNonNull($.active, "expected parameter 'active' to be non-null");
            $.description = Objects.requireNonNull($.description, "expected parameter 'description' to be non-null");
            $.issueType = Objects.requireNonNull($.issueType, "expected parameter 'issueType' to be non-null");
            $.profile = Objects.requireNonNull($.profile, "expected parameter 'profile' to be non-null");
            $.projectKey = Objects.requireNonNull($.projectKey, "expected parameter 'projectKey' to be non-null");
            $.summary = Objects.requireNonNull($.summary, "expected parameter 'summary' to be non-null");
            $.url = Objects.requireNonNull($.url, "expected parameter 'url' to be non-null");
            $.username = Objects.requireNonNull($.username, "expected parameter 'username' to be non-null");
            return $;
        }
    }

}