# Authenticator
Authenticator/Resolver for tid: schema

When installed on a portable computer this code will respond to a URI of the form tid:{method}:{id} to resolve the id using the methdod
if that method is trusted by this code. The code uses the TrustRepository.{org, us} to determine if the method is to be trusted.
