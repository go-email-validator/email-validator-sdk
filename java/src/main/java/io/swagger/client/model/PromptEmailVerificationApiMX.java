/*
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * OpenAPI spec version: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * PromptEmailVerificationApiMX
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-02-05T12:42:25.901Z[GMT]")
public class PromptEmailVerificationApiMX {
  @SerializedName("accepts_mail")
  private Boolean acceptsMail = null;

  @SerializedName("records")
  private List<String> records = null;

  public PromptEmailVerificationApiMX acceptsMail(Boolean acceptsMail) {
    this.acceptsMail = acceptsMail;
    return this;
  }

   /**
   * Get acceptsMail
   * @return acceptsMail
  **/
  @Schema(description = "")
  public Boolean isAcceptsMail() {
    return acceptsMail;
  }

  public void setAcceptsMail(Boolean acceptsMail) {
    this.acceptsMail = acceptsMail;
  }

  public PromptEmailVerificationApiMX records(List<String> records) {
    this.records = records;
    return this;
  }

  public PromptEmailVerificationApiMX addRecordsItem(String recordsItem) {
    if (this.records == null) {
      this.records = new ArrayList<String>();
    }
    this.records.add(recordsItem);
    return this;
  }

   /**
   * Get records
   * @return records
  **/
  @Schema(description = "")
  public List<String> getRecords() {
    return records;
  }

  public void setRecords(List<String> records) {
    this.records = records;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PromptEmailVerificationApiMX promptEmailVerificationApiMX = (PromptEmailVerificationApiMX) o;
    return Objects.equals(this.acceptsMail, promptEmailVerificationApiMX.acceptsMail) &&
        Objects.equals(this.records, promptEmailVerificationApiMX.records);
  }

  @Override
  public int hashCode() {
    return Objects.hash(acceptsMail, records);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PromptEmailVerificationApiMX {\n");
    
    sb.append("    acceptsMail: ").append(toIndentedString(acceptsMail)).append("\n");
    sb.append("    records: ").append(toIndentedString(records)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
