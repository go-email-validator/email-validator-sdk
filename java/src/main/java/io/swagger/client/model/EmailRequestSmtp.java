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
import java.math.BigDecimal;
/**
 * EmailRequestSmtp
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-02-03T16:29:40.837Z[GMT]")
public class EmailRequestSmtp {
  @SerializedName("email_from")
  private String emailFrom = user@example.org;

  @SerializedName("hello_name")
  private String helloName = "localhost";

  @SerializedName("proxy")
  private String proxy = null;

  @SerializedName("timeout_connection")
  private BigDecimal timeoutConnection = new BigDecimal(5.0);

  @SerializedName("timeout_response")
  private BigDecimal timeoutResponse = null;

  @SerializedName("port")
  private Integer port = 25;

  public EmailRequestSmtp emailFrom(String emailFrom) {
    this.emailFrom = emailFrom;
    return this;
  }

   /**
   * Get emailFrom
   * @return emailFrom
  **/
  @Schema(example = "user@example.org", description = "")
  public String getEmailFrom() {
    return emailFrom;
  }

  public void setEmailFrom(String emailFrom) {
    this.emailFrom = emailFrom;
  }

  public EmailRequestSmtp helloName(String helloName) {
    this.helloName = helloName;
    return this;
  }

   /**
   * Get helloName
   * @return helloName
  **/
  @Schema(example = "localhost", description = "")
  public String getHelloName() {
    return helloName;
  }

  public void setHelloName(String helloName) {
    this.helloName = helloName;
  }

  public EmailRequestSmtp proxy(String proxy) {
    this.proxy = proxy;
    return this;
  }

   /**
   * Versions - SOCKS4, SOCKS4A and SOCKS5. Format -  schema://username:password@host:port. 
   * @return proxy
  **/
  @Schema(description = "Versions - SOCKS4, SOCKS4A and SOCKS5. Format -  schema://username:password@host:port. ")
  public String getProxy() {
    return proxy;
  }

  public void setProxy(String proxy) {
    this.proxy = proxy;
  }

  public EmailRequestSmtp timeoutConnection(BigDecimal timeoutConnection) {
    this.timeoutConnection = timeoutConnection;
    return this;
  }

   /**
   * timeout creating smtp connection
   * @return timeoutConnection
  **/
  @Schema(description = "timeout creating smtp connection")
  public BigDecimal getTimeoutConnection() {
    return timeoutConnection;
  }

  public void setTimeoutConnection(BigDecimal timeoutConnection) {
    this.timeoutConnection = timeoutConnection;
  }

  public EmailRequestSmtp timeoutResponse(BigDecimal timeoutResponse) {
    this.timeoutResponse = timeoutResponse;
    return this;
  }

   /**
   * timeout of communication with smtp server
   * @return timeoutResponse
  **/
  @Schema(description = "timeout of communication with smtp server")
  public BigDecimal getTimeoutResponse() {
    return timeoutResponse;
  }

  public void setTimeoutResponse(BigDecimal timeoutResponse) {
    this.timeoutResponse = timeoutResponse;
  }

  public EmailRequestSmtp port(Integer port) {
    this.port = port;
    return this;
  }

   /**
   * smtp port remote server
   * @return port
  **/
  @Schema(example = "25", description = "smtp port remote server")
  public Integer getPort() {
    return port;
  }

  public void setPort(Integer port) {
    this.port = port;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EmailRequestSmtp emailRequestSmtp = (EmailRequestSmtp) o;
    return Objects.equals(this.emailFrom, emailRequestSmtp.emailFrom) &&
        Objects.equals(this.helloName, emailRequestSmtp.helloName) &&
        Objects.equals(this.proxy, emailRequestSmtp.proxy) &&
        Objects.equals(this.timeoutConnection, emailRequestSmtp.timeoutConnection) &&
        Objects.equals(this.timeoutResponse, emailRequestSmtp.timeoutResponse) &&
        Objects.equals(this.port, emailRequestSmtp.port);
  }

  @Override
  public int hashCode() {
    return Objects.hash(emailFrom, helloName, proxy, timeoutConnection, timeoutResponse, port);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailRequestSmtp {\n");
    
    sb.append("    emailFrom: ").append(toIndentedString(emailFrom)).append("\n");
    sb.append("    helloName: ").append(toIndentedString(helloName)).append("\n");
    sb.append("    proxy: ").append(toIndentedString(proxy)).append("\n");
    sb.append("    timeoutConnection: ").append(toIndentedString(timeoutConnection)).append("\n");
    sb.append("    timeoutResponse: ").append(toIndentedString(timeoutResponse)).append("\n");
    sb.append("    port: ").append(toIndentedString(port)).append("\n");
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
