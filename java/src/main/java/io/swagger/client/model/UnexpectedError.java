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
import java.util.HashMap;
import java.util.List;
import java.util.Map;
/**
 * UnexpectedError
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-02-03T17:38:40.051Z[GMT]")
public class UnexpectedError {
  @SerializedName("code")
  private Integer code = null;

  @SerializedName("message")
  private String message = null;

  @SerializedName("details")
  private Map<String, Object> details = null;

  public UnexpectedError code(Integer code) {
    this.code = code;
    return this;
  }

   /**
   * Get code
   * @return code
  **/
  @Schema(description = "")
  public Integer getCode() {
    return code;
  }

  public void setCode(Integer code) {
    this.code = code;
  }

  public UnexpectedError message(String message) {
    this.message = message;
    return this;
  }

   /**
   * Get message
   * @return message
  **/
  @Schema(description = "")
  public String getMessage() {
    return message;
  }

  public void setMessage(String message) {
    this.message = message;
  }

  public UnexpectedError details(Map<String, Object> details) {
    this.details = details;
    return this;
  }

  public UnexpectedError putDetailsItem(String key, Object detailsItem) {
    if (this.details == null) {
      this.details = new HashMap<String, Object>();
    }
    this.details.put(key, detailsItem);
    return this;
  }

   /**
   * Get details
   * @return details
  **/
  @Schema(description = "")
  public Map<String, Object> getDetails() {
    return details;
  }

  public void setDetails(Map<String, Object> details) {
    this.details = details;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UnexpectedError unexpectedError = (UnexpectedError) o;
    return Objects.equals(this.code, unexpectedError.code) &&
        Objects.equals(this.message, unexpectedError.message) &&
        Objects.equals(this.details, unexpectedError.details);
  }

  @Override
  public int hashCode() {
    return Objects.hash(code, message, details);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UnexpectedError {\n");
    
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    details: ").append(toIndentedString(details)).append("\n");
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
