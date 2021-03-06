/*
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.CheckIfEmailExistMX;
import org.openapitools.client.model.CheckIfEmailExistMisc;
import org.openapitools.client.model.CheckIfEmailExistSMTP;
import org.openapitools.client.model.CheckIfEmailExistSyntax;

/**
 * CheckIfEmailExistResult
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T07:42:09.412Z[GMT]")
public class CheckIfEmailExistResult {
  public static final String SERIALIZED_NAME_INPUT = "input";
  @SerializedName(SERIALIZED_NAME_INPUT)
  private String input;

  public static final String SERIALIZED_NAME_IS_REACHABLE = "is_reachable";
  @SerializedName(SERIALIZED_NAME_IS_REACHABLE)
  private String isReachable;

  public static final String SERIALIZED_NAME_MISC = "misc";
  @SerializedName(SERIALIZED_NAME_MISC)
  private CheckIfEmailExistMisc misc;

  public static final String SERIALIZED_NAME_MX = "mx";
  @SerializedName(SERIALIZED_NAME_MX)
  private CheckIfEmailExistMX mx;

  public static final String SERIALIZED_NAME_SMTP = "smtp";
  @SerializedName(SERIALIZED_NAME_SMTP)
  private CheckIfEmailExistSMTP smtp;

  public static final String SERIALIZED_NAME_SYNTAX = "syntax";
  @SerializedName(SERIALIZED_NAME_SYNTAX)
  private CheckIfEmailExistSyntax syntax;

  public static final String SERIALIZED_NAME_ERROR = "error";
  @SerializedName(SERIALIZED_NAME_ERROR)
  private String error;


  public CheckIfEmailExistResult input(String input) {
    
    this.input = input;
    return this;
  }

   /**
   * Get input
   * @return input
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getInput() {
    return input;
  }


  public void setInput(String input) {
    this.input = input;
  }


  public CheckIfEmailExistResult isReachable(String isReachable) {
    
    this.isReachable = isReachable;
    return this;
  }

   /**
   * Get isReachable
   * @return isReachable
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getIsReachable() {
    return isReachable;
  }


  public void setIsReachable(String isReachable) {
    this.isReachable = isReachable;
  }


  public CheckIfEmailExistResult misc(CheckIfEmailExistMisc misc) {
    
    this.misc = misc;
    return this;
  }

   /**
   * Get misc
   * @return misc
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CheckIfEmailExistMisc getMisc() {
    return misc;
  }


  public void setMisc(CheckIfEmailExistMisc misc) {
    this.misc = misc;
  }


  public CheckIfEmailExistResult mx(CheckIfEmailExistMX mx) {
    
    this.mx = mx;
    return this;
  }

   /**
   * Get mx
   * @return mx
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CheckIfEmailExistMX getMx() {
    return mx;
  }


  public void setMx(CheckIfEmailExistMX mx) {
    this.mx = mx;
  }


  public CheckIfEmailExistResult smtp(CheckIfEmailExistSMTP smtp) {
    
    this.smtp = smtp;
    return this;
  }

   /**
   * Get smtp
   * @return smtp
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CheckIfEmailExistSMTP getSmtp() {
    return smtp;
  }


  public void setSmtp(CheckIfEmailExistSMTP smtp) {
    this.smtp = smtp;
  }


  public CheckIfEmailExistResult syntax(CheckIfEmailExistSyntax syntax) {
    
    this.syntax = syntax;
    return this;
  }

   /**
   * Get syntax
   * @return syntax
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CheckIfEmailExistSyntax getSyntax() {
    return syntax;
  }


  public void setSyntax(CheckIfEmailExistSyntax syntax) {
    this.syntax = syntax;
  }


  public CheckIfEmailExistResult error(String error) {
    
    this.error = error;
    return this;
  }

   /**
   * Get error
   * @return error
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getError() {
    return error;
  }


  public void setError(String error) {
    this.error = error;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CheckIfEmailExistResult checkIfEmailExistResult = (CheckIfEmailExistResult) o;
    return Objects.equals(this.input, checkIfEmailExistResult.input) &&
        Objects.equals(this.isReachable, checkIfEmailExistResult.isReachable) &&
        Objects.equals(this.misc, checkIfEmailExistResult.misc) &&
        Objects.equals(this.mx, checkIfEmailExistResult.mx) &&
        Objects.equals(this.smtp, checkIfEmailExistResult.smtp) &&
        Objects.equals(this.syntax, checkIfEmailExistResult.syntax) &&
        Objects.equals(this.error, checkIfEmailExistResult.error);
  }

  @Override
  public int hashCode() {
    return Objects.hash(input, isReachable, misc, mx, smtp, syntax, error);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CheckIfEmailExistResult {\n");
    sb.append("    input: ").append(toIndentedString(input)).append("\n");
    sb.append("    isReachable: ").append(toIndentedString(isReachable)).append("\n");
    sb.append("    misc: ").append(toIndentedString(misc)).append("\n");
    sb.append("    mx: ").append(toIndentedString(mx)).append("\n");
    sb.append("    smtp: ").append(toIndentedString(smtp)).append("\n");
    sb.append("    syntax: ").append(toIndentedString(syntax)).append("\n");
    sb.append("    error: ").append(toIndentedString(error)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

