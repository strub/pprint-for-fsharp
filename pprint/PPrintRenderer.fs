(* ------------------------------------------------------------------------- *)
(* Based on PPrint for OCaml                                                 *)
(*   Francois Pottier, INRIA Paris-Rocquencourt                              *)
(*   Nicolas Pouillard, IT University of Copenhagen                          *)
(*   Copyright 2007-2014 INRIA. All rights reserved.                         *)
(*                                                                           *)
(* For the F# Port                                                           *)
(*   Pierre-Yves Strub, IMDEA Software Institute                             *)
(*   Copyright 2014, IMDEA Software Institute. All rights reversed.          *)
(*                                                                           *)
(* Distributed under the terms of the CeCILL-C license, as described         *)
(* in the file LICENSE.                                                      *)
(* ------------------------------------------------------------------------- *)

#light "off"

module FSharp.PPrint.Renderer

(** A common signature for the multiple document renderers proposed by {!PPrintEngine}. *)

type Renderer<'channel, 'document> =
  interface
    (** [pretty rfrac width channel document] pretty-prints the document
        [document] into the output channel [channel]. The parameter [width] is
        the maximum number of characters per line. The parameter [rfrac] is the
        ribbon width, a fraction relative to [width]. The ribbon width is the
        maximum number of non-indentation characters per line. *)
    abstract pretty: float -> int -> 'channel -> 'document -> unit

    (** [compact channel document] prints the document [document] to the output
        channel [channel]. No indentation is used. All newline instructions are
        respected, that is, no groups are flattened. *)
    abstract compact: 'channel -> 'document -> unit
  end
