# WakaSkies

<img src="https://github.com/MoonstoneStudios/WakaSkies/blob/main/wakaskies%20logo.png?raw=true)" width="150px" height="150px" />

Generate a 3D model of your time spent programming! You can export it as an STL for 3D printing! WakaSkies is like GitHub Skylines but for time spent programming! This project was written in C# and uses [MonoGame](https://www.monogame.net/) for the desktop client. 
You need to have a WakaTime account to use. [Take me to the downloads!](https://github.com/MoonstoneStudios/WakaSkies/releases)

## Project Breakdown
- `WakaSkies.WakaAPI` - This project houses the code related to making a request to WakaTime and loading it.
- `WakaSkies.ModelBuilder` - This project takes the data received from the WakaAPI and turns it into a 3D model.
- `WakaSkies.Desktop` - This is the app that can be run on the computer.
- `Tests/` - A directory full of API and ModelBuilder tests.

# Important
This app has only been tested on a Windows computer. I am not a verified Apple developer either so it may not work at all on MacOS. 
But, a website release is planned so stay tuned!

# Why Does WakaSkies Need My WakaTime API Key?
In order to retreive data from WakaTime, WakaSkies needs your API key.
WakaSkies uses WakaTime's [Insights API Enpoint](https://wakatime.com/developers#insights). This requires a user's API key to access.
**WakaSkies does not use your API key for anything other than getting your programming statistics.**

# Screenshots
<img src="https://github.com/MoonstoneStudios/WakaSkies/blob/main/Images/screenshot1.png?raw=true)" width="600px" />
<img src="https://github.com/MoonstoneStudios/WakaSkies/blob/main/Images/screenshot2.png?raw=true)" width="600px" />
<img src="https://github.com/MoonstoneStudios/WakaSkies/blob/main/Images/screenshot3.png?raw=true)" width="600px" />

# Roadmap/Ideas for future releases
- Website release is planned.
- See [the project board](https://github.com/users/MoonstoneStudios/projects/1)

# Licenses and Credit

### Image/Icon Credits:
- [Home icons created by Dave Gandy - Flaticon](https://www.flaticon.com/free-icons/home)
- [Download Icon Source](https://www.iconsdb.com/white-icons/download-2-icon.html)
- [Question Mark Image Source](https://icons8.com/icon/98973/question-mark)

### Open-Source Licenses:
[Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
<details>
    <summary>Newtonsoft.Json License:</summary>
    
    The MIT License (MIT)

    Copyright (c) 2007 James Newton-King

    Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
</details>

---

[Stackoverflow answer on how to read file from embedded resouces](https://stackoverflow.com/a/3314213)
<details>
    <summary>License:</summary>

    Attribution-ShareAlike 4.0 International

    =======================================================================

    Creative Commons Corporation ("Creative Commons") is not a law firm and
    does not provide legal services or legal advice. Distribution of
    Creative Commons public licenses does not create a lawyer-client or
    other relationship. Creative Commons makes its licenses and related
    information available on an "as-is" basis. Creative Commons gives no
    warranties regarding its licenses, any material licensed under their
    terms and conditions, or any related information. Creative Commons
    disclaims all liability for damages resulting from their use to the
    fullest extent possible.

    Using Creative Commons Public Licenses

    Creative Commons public licenses provide a standard set of terms and
    conditions that creators and other rights holders may use to share
    original works of authorship and other material subject to copyright
    and certain other rights specified in the public license below. The
    following considerations are for informational purposes only, are not
    exhaustive, and do not form part of our licenses.

        Considerations for licensors: Our public licenses are
        intended for use by those authorized to give the public
        permission to use material in ways otherwise restricted by
        copyright and certain other rights. Our licenses are
        irrevocable. Licensors should read and understand the terms
        and conditions of the license they choose before applying it.
        Licensors should also secure all rights necessary before
        applying our licenses so that the public can reuse the
        material as expected. Licensors should clearly mark any
        material not subject to the license. This includes other CC-
        licensed material, or material used under an exception or
        limitation to copyright. More considerations for licensors:
        wiki.creativecommons.org/Considerations_for_licensors

        Considerations for the public: By using one of our public
        licenses, a licensor grants the public permission to use the
        licensed material under specified terms and conditions. If
        the licensor's permission is not necessary for any reason--for
        example, because of any applicable exception or limitation to
        copyright--then that use is not regulated by the license. Our
        licenses grant only permissions under copyright and certain
        other rights that a licensor has authority to grant. Use of
        the licensed material may still be restricted for other
        reasons, including because others have copyright or other
        rights in the material. A licensor may make special requests,
        such as asking that all changes be marked or described.
        Although not required by our licenses, you are encouraged to
        respect those requests where reasonable. More considerations
        for the public:
        wiki.creativecommons.org/Considerations_for_licensees

    =======================================================================

    Creative Commons Attribution-ShareAlike 4.0 International Public
    License

    By exercising the Licensed Rights (defined below), You accept and agree
    to be bound by the terms and conditions of this Creative Commons
    Attribution-ShareAlike 4.0 International Public License ("Public
    License"). To the extent this Public License may be interpreted as a
    contract, You are granted the Licensed Rights in consideration of Your
    acceptance of these terms and conditions, and the Licensor grants You
    such rights in consideration of benefits the Licensor receives from
    making the Licensed Material available under these terms and
    conditions.


    Section 1 -- Definitions.

    a. Adapted Material means material subject to Copyright and Similar
        Rights that is derived from or based upon the Licensed Material
        and in which the Licensed Material is translated, altered,
        arranged, transformed, or otherwise modified in a manner requiring
        permission under the Copyright and Similar Rights held by the
        Licensor. For purposes of this Public License, where the Licensed
        Material is a musical work, performance, or sound recording,
        Adapted Material is always produced where the Licensed Material is
        synched in timed relation with a moving image.

    b. Adapter's License means the license You apply to Your Copyright
        and Similar Rights in Your contributions to Adapted Material in
        accordance with the terms and conditions of this Public License.

    c. BY-SA Compatible License means a license listed at
        creativecommons.org/compatiblelicenses, approved by Creative
        Commons as essentially the equivalent of this Public License.

    d. Copyright and Similar Rights means copyright and/or similar rights
        closely related to copyright including, without limitation,
        performance, broadcast, sound recording, and Sui Generis Database
        Rights, without regard to how the rights are labeled or
        categorized. For purposes of this Public License, the rights
        specified in Section 2(b)(1)-(2) are not Copyright and Similar
        Rights.

    e. Effective Technological Measures means those measures that, in the
        absence of proper authority, may not be circumvented under laws
        fulfilling obligations under Article 11 of the WIPO Copyright
        Treaty adopted on December 20, 1996, and/or similar international
        agreements.

    f. Exceptions and Limitations means fair use, fair dealing, and/or
        any other exception or limitation to Copyright and Similar Rights
        that applies to Your use of the Licensed Material.

    g. License Elements means the license attributes listed in the name
        of a Creative Commons Public License. The License Elements of this
        Public License are Attribution and ShareAlike.

    h. Licensed Material means the artistic or literary work, database,
        or other material to which the Licensor applied this Public
        License.

    i. Licensed Rights means the rights granted to You subject to the
        terms and conditions of this Public License, which are limited to
        all Copyright and Similar Rights that apply to Your use of the
        Licensed Material and that the Licensor has authority to license.

    j. Licensor means the individual(s) or entity(ies) granting rights
        under this Public License.

    k. Share means to provide material to the public by any means or
        process that requires permission under the Licensed Rights, such
        as reproduction, public display, public performance, distribution,
        dissemination, communication, or importation, and to make material
        available to the public including in ways that members of the
        public may access the material from a place and at a time
        individually chosen by them.

    l. Sui Generis Database Rights means rights other than copyright
        resulting from Directive 96/9/EC of the European Parliament and of
        the Council of 11 March 1996 on the legal protection of databases,
        as amended and/or succeeded, as well as other essentially
        equivalent rights anywhere in the world.

    m. You means the individual or entity exercising the Licensed Rights
        under this Public License. Your has a corresponding meaning.


    Section 2 -- Scope.

    a. License grant.

        1. Subject to the terms and conditions of this Public License,
            the Licensor hereby grants You a worldwide, royalty-free,
            non-sublicensable, non-exclusive, irrevocable license to
            exercise the Licensed Rights in the Licensed Material to:

                a. reproduce and Share the Licensed Material, in whole or
                in part; and

                b. produce, reproduce, and Share Adapted Material.

        2. Exceptions and Limitations. For the avoidance of doubt, where
            Exceptions and Limitations apply to Your use, this Public
            License does not apply, and You do not need to comply with
            its terms and conditions.

        3. Term. The term of this Public License is specified in Section
            6(a).

        4. Media and formats; technical modifications allowed. The
            Licensor authorizes You to exercise the Licensed Rights in
            all media and formats whether now known or hereafter created,
            and to make technical modifications necessary to do so. The
            Licensor waives and/or agrees not to assert any right or
            authority to forbid You from making technical modifications
            necessary to exercise the Licensed Rights, including
            technical modifications necessary to circumvent Effective
            Technological Measures. For purposes of this Public License,
            simply making modifications authorized by this Section 2(a)
            (4) never produces Adapted Material.

        5. Downstream recipients.

                a. Offer from the Licensor -- Licensed Material. Every
                recipient of the Licensed Material automatically
                receives an offer from the Licensor to exercise the
                Licensed Rights under the terms and conditions of this
                Public License.

                b. Additional offer from the Licensor -- Adapted Material.
                Every recipient of Adapted Material from You
                automatically receives an offer from the Licensor to
                exercise the Licensed Rights in the Adapted Material
                under the conditions of the Adapter's License You apply.

                c. No downstream restrictions. You may not offer or impose
                any additional or different terms or conditions on, or
                apply any Effective Technological Measures to, the
                Licensed Material if doing so restricts exercise of the
                Licensed Rights by any recipient of the Licensed
                Material.

        6. No endorsement. Nothing in this Public License constitutes or
            may be construed as permission to assert or imply that You
            are, or that Your use of the Licensed Material is, connected
            with, or sponsored, endorsed, or granted official status by,
            the Licensor or others designated to receive attribution as
            provided in Section 3(a)(1)(A)(i).

    b. Other rights.

        1. Moral rights, such as the right of integrity, are not
            licensed under this Public License, nor are publicity,
            privacy, and/or other similar personality rights; however, to
            the extent possible, the Licensor waives and/or agrees not to
            assert any such rights held by the Licensor to the limited
            extent necessary to allow You to exercise the Licensed
            Rights, but not otherwise.

        2. Patent and trademark rights are not licensed under this
            Public License.

        3. To the extent possible, the Licensor waives any right to
            collect royalties from You for the exercise of the Licensed
            Rights, whether directly or through a collecting society
            under any voluntary or waivable statutory or compulsory
            licensing scheme. In all other cases the Licensor expressly
            reserves any right to collect such royalties.


    Section 3 -- License Conditions.

    Your exercise of the Licensed Rights is expressly made subject to the
    following conditions.

    a. Attribution.

        1. If You Share the Licensed Material (including in modified
            form), You must:

                a. retain the following if it is supplied by the Licensor
                with the Licensed Material:

                    i. identification of the creator(s) of the Licensed
                        Material and any others designated to receive
                        attribution, in any reasonable manner requested by
                        the Licensor (including by pseudonym if
                        designated);

                    ii. a copyright notice;

                iii. a notice that refers to this Public License;

                    iv. a notice that refers to the disclaimer of
                        warranties;

                    v. a URI or hyperlink to the Licensed Material to the
                        extent reasonably practicable;

                b. indicate if You modified the Licensed Material and
                retain an indication of any previous modifications; and

                c. indicate the Licensed Material is licensed under this
                Public License, and include the text of, or the URI or
                hyperlink to, this Public License.

        2. You may satisfy the conditions in Section 3(a)(1) in any
            reasonable manner based on the medium, means, and context in
            which You Share the Licensed Material. For example, it may be
            reasonable to satisfy the conditions by providing a URI or
            hyperlink to a resource that includes the required
            information.

        3. If requested by the Licensor, You must remove any of the
            information required by Section 3(a)(1)(A) to the extent
            reasonably practicable.

    b. ShareAlike.

        In addition to the conditions in Section 3(a), if You Share
        Adapted Material You produce, the following conditions also apply.

        1. The Adapter's License You apply must be a Creative Commons
            license with the same License Elements, this version or
            later, or a BY-SA Compatible License.

        2. You must include the text of, or the URI or hyperlink to, the
            Adapter's License You apply. You may satisfy this condition
            in any reasonable manner based on the medium, means, and
            context in which You Share Adapted Material.

        3. You may not offer or impose any additional or different terms
            or conditions on, or apply any Effective Technological
            Measures to, Adapted Material that restrict exercise of the
            rights granted under the Adapter's License You apply.


    Section 4 -- Sui Generis Database Rights.

    Where the Licensed Rights include Sui Generis Database Rights that
    apply to Your use of the Licensed Material:

    a. for the avoidance of doubt, Section 2(a)(1) grants You the right
        to extract, reuse, reproduce, and Share all or a substantial
        portion of the contents of the database;

    b. if You include all or a substantial portion of the database
        contents in a database in which You have Sui Generis Database
        Rights, then the database in which You have Sui Generis Database
        Rights (but not its individual contents) is Adapted Material,
        including for purposes of Section 3(b); and

    c. You must comply with the conditions in Section 3(a) if You Share
        all or a substantial portion of the contents of the database.

    For the avoidance of doubt, this Section 4 supplements and does not
    replace Your obligations under this Public License where the Licensed
    Rights include other Copyright and Similar Rights.


    Section 5 -- Disclaimer of Warranties and Limitation of Liability.

    a. UNLESS OTHERWISE SEPARATELY UNDERTAKEN BY THE LICENSOR, TO THE
        EXTENT POSSIBLE, THE LICENSOR OFFERS THE LICENSED MATERIAL AS-IS
        AND AS-AVAILABLE, AND MAKES NO REPRESENTATIONS OR WARRANTIES OF
        ANY KIND CONCERNING THE LICENSED MATERIAL, WHETHER EXPRESS,
        IMPLIED, STATUTORY, OR OTHER. THIS INCLUDES, WITHOUT LIMITATION,
        WARRANTIES OF TITLE, MERCHANTABILITY, FITNESS FOR A PARTICULAR
        PURPOSE, NON-INFRINGEMENT, ABSENCE OF LATENT OR OTHER DEFECTS,
        ACCURACY, OR THE PRESENCE OR ABSENCE OF ERRORS, WHETHER OR NOT
        KNOWN OR DISCOVERABLE. WHERE DISCLAIMERS OF WARRANTIES ARE NOT
        ALLOWED IN FULL OR IN PART, THIS DISCLAIMER MAY NOT APPLY TO YOU.

    b. TO THE EXTENT POSSIBLE, IN NO EVENT WILL THE LICENSOR BE LIABLE
        TO YOU ON ANY LEGAL THEORY (INCLUDING, WITHOUT LIMITATION,
        NEGLIGENCE) OR OTHERWISE FOR ANY DIRECT, SPECIAL, INDIRECT,
        INCIDENTAL, CONSEQUENTIAL, PUNITIVE, EXEMPLARY, OR OTHER LOSSES,
        COSTS, EXPENSES, OR DAMAGES ARISING OUT OF THIS PUBLIC LICENSE OR
        USE OF THE LICENSED MATERIAL, EVEN IF THE LICENSOR HAS BEEN
        ADVISED OF THE POSSIBILITY OF SUCH LOSSES, COSTS, EXPENSES, OR
        DAMAGES. WHERE A LIMITATION OF LIABILITY IS NOT ALLOWED IN FULL OR
        IN PART, THIS LIMITATION MAY NOT APPLY TO YOU.

    c. The disclaimer of warranties and limitation of liability provided
        above shall be interpreted in a manner that, to the extent
        possible, most closely approximates an absolute disclaimer and
        waiver of all liability.


    Section 6 -- Term and Termination.

    a. This Public License applies for the term of the Copyright and
        Similar Rights licensed here. However, if You fail to comply with
        this Public License, then Your rights under this Public License
        terminate automatically.

    b. Where Your right to use the Licensed Material has terminated under
        Section 6(a), it reinstates:

        1. automatically as of the date the violation is cured, provided
            it is cured within 30 days of Your discovery of the
            violation; or

        2. upon express reinstatement by the Licensor.

        For the avoidance of doubt, this Section 6(b) does not affect any
        right the Licensor may have to seek remedies for Your violations
        of this Public License.

    c. For the avoidance of doubt, the Licensor may also offer the
        Licensed Material under separate terms or conditions or stop
        distributing the Licensed Material at any time; however, doing so
        will not terminate this Public License.

    d. Sections 1, 5, 6, 7, and 8 survive termination of this Public
        License.


    Section 7 -- Other Terms and Conditions.

    a. The Licensor shall not be bound by any additional or different
        terms or conditions communicated by You unless expressly agreed.

    b. Any arrangements, understandings, or agreements regarding the
        Licensed Material not stated herein are separate from and
        independent of the terms and conditions of this Public License.


    Section 8 -- Interpretation.

    a. For the avoidance of doubt, this Public License does not, and
        shall not be interpreted to, reduce, limit, restrict, or impose
        conditions on any use of the Licensed Material that could lawfully
        be made without permission under this Public License.

    b. To the extent possible, if any provision of this Public License is
        deemed unenforceable, it shall be automatically reformed to the
        minimum extent necessary to make it enforceable. If the provision
        cannot be reformed, it shall be severed from this Public License
        without affecting the enforceability of the remaining terms and
        conditions.

    c. No term or condition of this Public License will be waived and no
        failure to comply consented to unless expressly agreed to by the
        Licensor.

    d. Nothing in this Public License constitutes or may be interpreted
        as a limitation upon, or waiver of, any privileges and immunities
        that apply to the Licensor or You, including from the legal
        processes of any jurisdiction or authority.


    =======================================================================

    Creative Commons is not a party to its public
    licenses. Notwithstanding, Creative Commons may elect to apply one of
    its public licenses to material it publishes and in those instances
    will be considered the “Licensor.” The text of the Creative Commons
    public licenses is dedicated to the public domain under the CC0 Public
    Domain Dedication. Except for the limited purpose of indicating that
    material is shared under a Creative Commons public license or as
    otherwise permitted by the Creative Commons policies published at
    creativecommons.org/policies, Creative Commons does not authorize the
    use of the trademark "Creative Commons" or any other trademark or logo
    of Creative Commons without its prior written consent including,
    without limitation, in connection with any unauthorized modifications
    to any of its public licenses or any other arrangements,
    understandings, or agreements concerning use of licensed material. For
    the avoidance of doubt, this paragraph does not form part of the
    public licenses.

    Creative Commons may be contacted at creativecommons.org.

</details>

---

[Myra](https://github.com/rds1983/Myra)
<details>
    <summary>Myra's License</summary>

    MIT License

    Copyright (c) 2017-2020 The Myra Team

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.

</details>

---

[Stackoverflow answer for rotating an object in a circular path](https://gamedev.stackexchange.com/a/9610)
<details>
    <summary>License:</summary>

    Creative Commons Legal Code

    Attribution-ShareAlike 3.0 Unported

        CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
        LEGAL SERVICES. DISTRIBUTION OF THIS LICENSE DOES NOT CREATE AN
        ATTORNEY-CLIENT RELATIONSHIP. CREATIVE COMMONS PROVIDES THIS
        INFORMATION ON AN "AS-IS" BASIS. CREATIVE COMMONS MAKES NO WARRANTIES
        REGARDING THE INFORMATION PROVIDED, AND DISCLAIMS LIABILITY FOR
        DAMAGES RESULTING FROM ITS USE.

    License

    THE WORK (AS DEFINED BELOW) IS PROVIDED UNDER THE TERMS OF THIS CREATIVE
    COMMONS PUBLIC LICENSE ("CCPL" OR "LICENSE"). THE WORK IS PROTECTED BY
    COPYRIGHT AND/OR OTHER APPLICABLE LAW. ANY USE OF THE WORK OTHER THAN AS
    AUTHORIZED UNDER THIS LICENSE OR COPYRIGHT LAW IS PROHIBITED.

    BY EXERCISING ANY RIGHTS TO THE WORK PROVIDED HERE, YOU ACCEPT AND AGREE
    TO BE BOUND BY THE TERMS OF THIS LICENSE. TO THE EXTENT THIS LICENSE MAY
    BE CONSIDERED TO BE A CONTRACT, THE LICENSOR GRANTS YOU THE RIGHTS
    CONTAINED HERE IN CONSIDERATION OF YOUR ACCEPTANCE OF SUCH TERMS AND
    CONDITIONS.

    1. Definitions

    a. "Adaptation" means a work based upon the Work, or upon the Work and
        other pre-existing works, such as a translation, adaptation,
        derivative work, arrangement of music or other alterations of a
        literary or artistic work, or phonogram or performance and includes
        cinematographic adaptations or any other form in which the Work may be
        recast, transformed, or adapted including in any form recognizably
        derived from the original, except that a work that constitutes a
        Collection will not be considered an Adaptation for the purpose of
        this License. For the avoidance of doubt, where the Work is a musical
        work, performance or phonogram, the synchronization of the Work in
        timed-relation with a moving image ("synching") will be considered an
        Adaptation for the purpose of this License.
    b. "Collection" means a collection of literary or artistic works, such as
        encyclopedias and anthologies, or performances, phonograms or
        broadcasts, or other works or subject matter other than works listed
        in Section 1(f) below, which, by reason of the selection and
        arrangement of their contents, constitute intellectual creations, in
        which the Work is included in its entirety in unmodified form along
        with one or more other contributions, each constituting separate and
        independent works in themselves, which together are assembled into a
        collective whole. A work that constitutes a Collection will not be
        considered an Adaptation (as defined below) for the purposes of this
        License.
    c. "Creative Commons Compatible License" means a license that is listed
        at https://creativecommons.org/compatiblelicenses that has been
        approved by Creative Commons as being essentially equivalent to this
        License, including, at a minimum, because that license: (i) contains
        terms that have the same purpose, meaning and effect as the License
        Elements of this License; and, (ii) explicitly permits the relicensing
        of adaptations of works made available under that license under this
        License or a Creative Commons jurisdiction license with the same
        License Elements as this License.
    d. "Distribute" means to make available to the public the original and
        copies of the Work or Adaptation, as appropriate, through sale or
        other transfer of ownership.
    e. "License Elements" means the following high-level license attributes
        as selected by Licensor and indicated in the title of this License:
        Attribution, ShareAlike.
    f. "Licensor" means the individual, individuals, entity or entities that
        offer(s) the Work under the terms of this License.
    g. "Original Author" means, in the case of a literary or artistic work,
        the individual, individuals, entity or entities who created the Work
        or if no individual or entity can be identified, the publisher; and in
        addition (i) in the case of a performance the actors, singers,
        musicians, dancers, and other persons who act, sing, deliver, declaim,
        play in, interpret or otherwise perform literary or artistic works or
        expressions of folklore; (ii) in the case of a phonogram the producer
        being the person or legal entity who first fixes the sounds of a
        performance or other sounds; and, (iii) in the case of broadcasts, the
        organization that transmits the broadcast.
    h. "Work" means the literary and/or artistic work offered under the terms
        of this License including without limitation any production in the
        literary, scientific and artistic domain, whatever may be the mode or
        form of its expression including digital form, such as a book,
        pamphlet and other writing; a lecture, address, sermon or other work
        of the same nature; a dramatic or dramatico-musical work; a
        choreographic work or entertainment in dumb show; a musical
        composition with or without words; a cinematographic work to which are
        assimilated works expressed by a process analogous to cinematography;
        a work of drawing, painting, architecture, sculpture, engraving or
        lithography; a photographic work to which are assimilated works
        expressed by a process analogous to photography; a work of applied
        art; an illustration, map, plan, sketch or three-dimensional work
        relative to geography, topography, architecture or science; a
        performance; a broadcast; a phonogram; a compilation of data to the
        extent it is protected as a copyrightable work; or a work performed by
        a variety or circus performer to the extent it is not otherwise
        considered a literary or artistic work.
    i. "You" means an individual or entity exercising rights under this
        License who has not previously violated the terms of this License with
        respect to the Work, or who has received express permission from the
        Licensor to exercise rights under this License despite a previous
        violation.
    j. "Publicly Perform" means to perform public recitations of the Work and
        to communicate to the public those public recitations, by any means or
        process, including by wire or wireless means or public digital
        performances; to make available to the public Works in such a way that
        members of the public may access these Works from a place and at a
        place individually chosen by them; to perform the Work to the public
        by any means or process and the communication to the public of the
        performances of the Work, including by public digital performance; to
        broadcast and rebroadcast the Work by any means including signs,
        sounds or images.
    k. "Reproduce" means to make copies of the Work by any means including
        without limitation by sound or visual recordings and the right of
        fixation and reproducing fixations of the Work, including storage of a
        protected performance or phonogram in digital form or other electronic
        medium.

    2. Fair Dealing Rights. Nothing in this License is intended to reduce,
    limit, or restrict any uses free from copyright or rights arising from
    limitations or exceptions that are provided for in connection with the
    copyright protection under copyright law or other applicable laws.

    3. License Grant. Subject to the terms and conditions of this License,
    Licensor hereby grants You a worldwide, royalty-free, non-exclusive,
    perpetual (for the duration of the applicable copyright) license to
    exercise the rights in the Work as stated below:

    a. to Reproduce the Work, to incorporate the Work into one or more
        Collections, and to Reproduce the Work as incorporated in the
        Collections;
    b. to create and Reproduce Adaptations provided that any such Adaptation,
        including any translation in any medium, takes reasonable steps to
        clearly label, demarcate or otherwise identify that changes were made
        to the original Work. For example, a translation could be marked "The
        original work was translated from English to Spanish," or a
        modification could indicate "The original work has been modified.";
    c. to Distribute and Publicly Perform the Work including as incorporated
        in Collections; and,
    d. to Distribute and Publicly Perform Adaptations.
    e. For the avoidance of doubt:

        i. Non-waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme cannot be waived, the Licensor
            reserves the exclusive right to collect such royalties for any
            exercise by You of the rights granted under this License;
        ii. Waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme can be waived, the Licensor waives the
            exclusive right to collect such royalties for any exercise by You
            of the rights granted under this License; and,
    iii. Voluntary License Schemes. The Licensor waives the right to
            collect royalties, whether individually or, in the event that the
            Licensor is a member of a collecting society that administers
            voluntary licensing schemes, via that society, from any exercise
            by You of the rights granted under this License.

    The above rights may be exercised in all media and formats whether now
    known or hereafter devised. The above rights include the right to make
    such modifications as are technically necessary to exercise the rights in
    other media and formats. Subject to Section 8(f), all rights not expressly
    granted by Licensor are hereby reserved.

    4. Restrictions. The license granted in Section 3 above is expressly made
    subject to and limited by the following restrictions:

    a. You may Distribute or Publicly Perform the Work only under the terms
        of this License. You must include a copy of, or the Uniform Resource
        Identifier (URI) for, this License with every copy of the Work You
        Distribute or Publicly Perform. You may not offer or impose any terms
        on the Work that restrict the terms of this License or the ability of
        the recipient of the Work to exercise the rights granted to that
        recipient under the terms of the License. You may not sublicense the
        Work. You must keep intact all notices that refer to this License and
        to the disclaimer of warranties with every copy of the Work You
        Distribute or Publicly Perform. When You Distribute or Publicly
        Perform the Work, You may not impose any effective technological
        measures on the Work that restrict the ability of a recipient of the
        Work from You to exercise the rights granted to that recipient under
        the terms of the License. This Section 4(a) applies to the Work as
        incorporated in a Collection, but this does not require the Collection
        apart from the Work itself to be made subject to the terms of this
        License. If You create a Collection, upon notice from any Licensor You
        must, to the extent practicable, remove from the Collection any credit
        as required by Section 4(c), as requested. If You create an
        Adaptation, upon notice from any Licensor You must, to the extent
        practicable, remove from the Adaptation any credit as required by
        Section 4(c), as requested.
    b. You may Distribute or Publicly Perform an Adaptation only under the
        terms of: (i) this License; (ii) a later version of this License with
        the same License Elements as this License; (iii) a Creative Commons
        jurisdiction license (either this or a later license version) that
        contains the same License Elements as this License (e.g.,
        Attribution-ShareAlike 3.0 US)); (iv) a Creative Commons Compatible
        License. If you license the Adaptation under one of the licenses
        mentioned in (iv), you must comply with the terms of that license. If
        you license the Adaptation under the terms of any of the licenses
        mentioned in (i), (ii) or (iii) (the "Applicable License"), you must
        comply with the terms of the Applicable License generally and the
        following provisions: (I) You must include a copy of, or the URI for,
        the Applicable License with every copy of each Adaptation You
        Distribute or Publicly Perform; (II) You may not offer or impose any
        terms on the Adaptation that restrict the terms of the Applicable
        License or the ability of the recipient of the Adaptation to exercise
        the rights granted to that recipient under the terms of the Applicable
        License; (III) You must keep intact all notices that refer to the
        Applicable License and to the disclaimer of warranties with every copy
        of the Work as included in the Adaptation You Distribute or Publicly
        Perform; (IV) when You Distribute or Publicly Perform the Adaptation,
        You may not impose any effective technological measures on the
        Adaptation that restrict the ability of a recipient of the Adaptation
        from You to exercise the rights granted to that recipient under the
        terms of the Applicable License. This Section 4(b) applies to the
        Adaptation as incorporated in a Collection, but this does not require
        the Collection apart from the Adaptation itself to be made subject to
        the terms of the Applicable License.
    c. If You Distribute, or Publicly Perform the Work or any Adaptations or
        Collections, You must, unless a request has been made pursuant to
        Section 4(a), keep intact all copyright notices for the Work and
        provide, reasonable to the medium or means You are utilizing: (i) the
        name of the Original Author (or pseudonym, if applicable) if supplied,
        and/or if the Original Author and/or Licensor designate another party
        or parties (e.g., a sponsor institute, publishing entity, journal) for
        attribution ("Attribution Parties") in Licensor's copyright notice,
        terms of service or by other reasonable means, the name of such party
        or parties; (ii) the title of the Work if supplied; (iii) to the
        extent reasonably practicable, the URI, if any, that Licensor
        specifies to be associated with the Work, unless such URI does not
        refer to the copyright notice or licensing information for the Work;
        and (iv) , consistent with Ssection 3(b), in the case of an
        Adaptation, a credit identifying the use of the Work in the Adaptation
        (e.g., "French translation of the Work by Original Author," or
        "Screenplay based on original Work by Original Author"). The credit
        required by this Section 4(c) may be implemented in any reasonable
        manner; provided, however, that in the case of a Adaptation or
        Collection, at a minimum such credit will appear, if a credit for all
        contributing authors of the Adaptation or Collection appears, then as
        part of these credits and in a manner at least as prominent as the
        credits for the other contributing authors. For the avoidance of
        doubt, You may only use the credit required by this Section for the
        purpose of attribution in the manner set out above and, by exercising
        Your rights under this License, You may not implicitly or explicitly
        assert or imply any connection with, sponsorship or endorsement by the
        Original Author, Licensor and/or Attribution Parties, as appropriate,
        of You or Your use of the Work, without the separate, express prior
        written permission of the Original Author, Licensor and/or Attribution
        Parties.
    d. Except as otherwise agreed in writing by the Licensor or as may be
        otherwise permitted by applicable law, if You Reproduce, Distribute or
        Publicly Perform the Work either by itself or as part of any
        Adaptations or Collections, You must not distort, mutilate, modify or
        take other derogatory action in relation to the Work which would be
        prejudicial to the Original Author's honor or reputation. Licensor
        agrees that in those jurisdictions (e.g. Japan), in which any exercise
        of the right granted in Section 3(b) of this License (the right to
        make Adaptations) would be deemed to be a distortion, mutilation,
        modification or other derogatory action prejudicial to the Original
        Author's honor and reputation, the Licensor will waive or not assert,
        as appropriate, this Section, to the fullest extent permitted by the
        applicable national law, to enable You to reasonably exercise Your
        right under Section 3(b) of this License (right to make Adaptations)
        but not otherwise.

    5. Representations, Warranties and Disclaimer

    UNLESS OTHERWISE MUTUALLY AGREED TO BY THE PARTIES IN WRITING, LICENSOR
    OFFERS THE WORK AS-IS AND MAKES NO REPRESENTATIONS OR WARRANTIES OF ANY
    KIND CONCERNING THE WORK, EXPRESS, IMPLIED, STATUTORY OR OTHERWISE,
    INCLUDING, WITHOUT LIMITATION, WARRANTIES OF TITLE, MERCHANTIBILITY,
    FITNESS FOR A PARTICULAR PURPOSE, NONINFRINGEMENT, OR THE ABSENCE OF
    LATENT OR OTHER DEFECTS, ACCURACY, OR THE PRESENCE OF ABSENCE OF ERRORS,
    WHETHER OR NOT DISCOVERABLE. SOME JURISDICTIONS DO NOT ALLOW THE EXCLUSION
    OF IMPLIED WARRANTIES, SO SUCH EXCLUSION MAY NOT APPLY TO YOU.

    6. Limitation on Liability. EXCEPT TO THE EXTENT REQUIRED BY APPLICABLE
    LAW, IN NO EVENT WILL LICENSOR BE LIABLE TO YOU ON ANY LEGAL THEORY FOR
    ANY SPECIAL, INCIDENTAL, CONSEQUENTIAL, PUNITIVE OR EXEMPLARY DAMAGES
    ARISING OUT OF THIS LICENSE OR THE USE OF THE WORK, EVEN IF LICENSOR HAS
    BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

    7. Termination

    a. This License and the rights granted hereunder will terminate
        automatically upon any breach by You of the terms of this License.
        Individuals or entities who have received Adaptations or Collections
        from You under this License, however, will not have their licenses
        terminated provided such individuals or entities remain in full
        compliance with those licenses. Sections 1, 2, 5, 6, 7, and 8 will
        survive any termination of this License.
    b. Subject to the above terms and conditions, the license granted here is
        perpetual (for the duration of the applicable copyright in the Work).
        Notwithstanding the above, Licensor reserves the right to release the
        Work under different license terms or to stop distributing the Work at
        any time; provided, however that any such election will not serve to
        withdraw this License (or any other license that has been, or is
        required to be, granted under the terms of this License), and this
        License will continue in full force and effect unless terminated as
        stated above.

    8. Miscellaneous

    a. Each time You Distribute or Publicly Perform the Work or a Collection,
        the Licensor offers to the recipient a license to the Work on the same
        terms and conditions as the license granted to You under this License.
    b. Each time You Distribute or Publicly Perform an Adaptation, Licensor
        offers to the recipient a license to the original Work on the same
        terms and conditions as the license granted to You under this License.
    c. If any provision of this License is invalid or unenforceable under
        applicable law, it shall not affect the validity or enforceability of
        the remainder of the terms of this License, and without further action
        by the parties to this agreement, such provision shall be reformed to
        the minimum extent necessary to make such provision valid and
        enforceable.
    d. No term or provision of this License shall be deemed waived and no
        breach consented to unless such waiver or consent shall be in writing
        and signed by the party to be charged with such waiver or consent.
    e. This License constitutes the entire agreement between the parties with
        respect to the Work licensed here. There are no understandings,
        agreements or representations with respect to the Work not specified
        here. Licensor shall not be bound by any additional provisions that
        may appear in any communication from You. This License may not be
        modified without the mutual written agreement of the Licensor and You.
    f. The rights granted under, and the subject matter referenced, in this
        License were drafted utilizing the terminology of the Berne Convention
        for the Protection of Literary and Artistic Works (as amended on
        September 28, 1979), the Rome Convention of 1961, the WIPO Copyright
        Treaty of 1996, the WIPO Performances and Phonograms Treaty of 1996
        and the Universal Copyright Convention (as revised on July 24, 1971).
        These rights and subject matter take effect in the relevant
        jurisdiction in which the License terms are sought to be enforced
        according to the corresponding provisions of the implementation of
        those treaty provisions in the applicable national law. If the
        standard suite of rights granted under applicable copyright law
        includes additional rights not granted under this License, such
        additional rights are deemed to be included in the License; this
        License is not intended to restrict the license of any rights under
        applicable law.


    Creative Commons Notice

        Creative Commons is not a party to this License, and makes no warranty
        whatsoever in connection with the Work. Creative Commons will not be
        liable to You or any party on any legal theory for any damages
        whatsoever, including without limitation any general, special,
        incidental or consequential damages arising in connection to this
        license. Notwithstanding the foregoing two (2) sentences, if Creative
        Commons has expressly identified itself as the Licensor hereunder, it
        shall have all rights and obligations of Licensor.

        Except for the limited purpose of indicating to the public that the
        Work is licensed under the CCPL, Creative Commons does not authorize
        the use by either party of the trademark "Creative Commons" or any
        related trademark or logo of Creative Commons without the prior
        written consent of Creative Commons. Any permitted use will be in
        compliance with Creative Commons' then-current trademark usage
        guidelines, as may be published on its website or otherwise made
        available upon request from time to time. For the avoidance of doubt,
        this trademark restriction does not form part of the License.

        Creative Commons may be contacted at https://creativecommons.org/.

</details>

---

[Serilog](https://github.com/serilog/serilog)
<details>
    <summary>License:</summary>

    Apache License
    Version 2.0, January 2004
    http://www.apache.org/licenses/

    TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION

    1. Definitions.

    "License" shall mean the terms and conditions for use, reproduction, and
    distribution as defined by Sections 1 through 9 of this document.

    "Licensor" shall mean the copyright owner or entity authorized by the copyright
    owner that is granting the License.

    "Legal Entity" shall mean the union of the acting entity and all other entities
    that control, are controlled by, or are under common control with that entity.
    For the purposes of this definition, "control" means (i) the power, direct or
    indirect, to cause the direction or management of such entity, whether by
    contract or otherwise, or (ii) ownership of fifty percent (50%) or more of the
    outstanding shares, or (iii) beneficial ownership of such entity.

    "You" (or "Your") shall mean an individual or Legal Entity exercising
    permissions granted by this License.

    "Source" form shall mean the preferred form for making modifications, including
    but not limited to software source code, documentation source, and configuration
    files.

    "Object" form shall mean any form resulting from mechanical transformation or
    translation of a Source form, including but not limited to compiled object code,
    generated documentation, and conversions to other media types.

    "Work" shall mean the work of authorship, whether in Source or Object form, made
    available under the License, as indicated by a copyright notice that is included
    in or attached to the work (an example is provided in the Appendix below).

    "Derivative Works" shall mean any work, whether in Source or Object form, that
    is based on (or derived from) the Work and for which the editorial revisions,
    annotations, elaborations, or other modifications represent, as a whole, an
    original work of authorship. For the purposes of this License, Derivative Works
    shall not include works that remain separable from, or merely link (or bind by
    name) to the interfaces of, the Work and Derivative Works thereof.

    "Contribution" shall mean any work of authorship, including the original version
    of the Work and any modifications or additions to that Work or Derivative Works
    thereof, that is intentionally submitted to Licensor for inclusion in the Work
    by the copyright owner or by an individual or Legal Entity authorized to submit
    on behalf of the copyright owner. For the purposes of this definition,
    "submitted" means any form of electronic, verbal, or written communication sent
    to the Licensor or its representatives, including but not limited to
    communication on electronic mailing lists, source code control systems, and
    issue tracking systems that are managed by, or on behalf of, the Licensor for
    the purpose of discussing and improving the Work, but excluding communication
    that is conspicuously marked or otherwise designated in writing by the copyright
    owner as "Not a Contribution."

    "Contributor" shall mean Licensor and any individual or Legal Entity on behalf
    of whom a Contribution has been received by Licensor and subsequently
    incorporated within the Work.

    2. Grant of Copyright License.

    Subject to the terms and conditions of this License, each Contributor hereby
    grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free,
    irrevocable copyright license to reproduce, prepare Derivative Works of,
    publicly display, publicly perform, sublicense, and distribute the Work and such
    Derivative Works in Source or Object form.

    3. Grant of Patent License.

    Subject to the terms and conditions of this License, each Contributor hereby
    grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free,
    irrevocable (except as stated in this section) patent license to make, have
    made, use, offer to sell, sell, import, and otherwise transfer the Work, where
    such license applies only to those patent claims licensable by such Contributor
    that are necessarily infringed by their Contribution(s) alone or by combination
    of their Contribution(s) with the Work to which such Contribution(s) was
    submitted. If You institute patent litigation against any entity (including a
    cross-claim or counterclaim in a lawsuit) alleging that the Work or a
    Contribution incorporated within the Work constitutes direct or contributory
    patent infringement, then any patent licenses granted to You under this License
    for that Work shall terminate as of the date such litigation is filed.

    4. Redistribution.

    You may reproduce and distribute copies of the Work or Derivative Works thereof
    in any medium, with or without modifications, and in Source or Object form,
    provided that You meet the following conditions:

    You must give any other recipients of the Work or Derivative Works a copy of
    this License; and
    You must cause any modified files to carry prominent notices stating that You
    changed the files; and
    You must retain, in the Source form of any Derivative Works that You distribute,
    all copyright, patent, trademark, and attribution notices from the Source form
    of the Work, excluding those notices that do not pertain to any part of the
    Derivative Works; and
    If the Work includes a "NOTICE" text file as part of its distribution, then any
    Derivative Works that You distribute must include a readable copy of the
    attribution notices contained within such NOTICE file, excluding those notices
    that do not pertain to any part of the Derivative Works, in at least one of the
    following places: within a NOTICE text file distributed as part of the
    Derivative Works; within the Source form or documentation, if provided along
    with the Derivative Works; or, within a display generated by the Derivative
    Works, if and wherever such third-party notices normally appear. The contents of
    the NOTICE file are for informational purposes only and do not modify the
    License. You may add Your own attribution notices within Derivative Works that
    You distribute, alongside or as an addendum to the NOTICE text from the Work,
    provided that such additional attribution notices cannot be construed as
    modifying the License.
    You may add Your own copyright statement to Your modifications and may provide
    additional or different license terms and conditions for use, reproduction, or
    distribution of Your modifications, or for any such Derivative Works as a whole,
    provided Your use, reproduction, and distribution of the Work otherwise complies
    with the conditions stated in this License.

    5. Submission of Contributions.

    Unless You explicitly state otherwise, any Contribution intentionally submitted
    for inclusion in the Work by You to the Licensor shall be under the terms and
    conditions of this License, without any additional terms or conditions.
    Notwithstanding the above, nothing herein shall supersede or modify the terms of
    any separate license agreement you may have executed with Licensor regarding
    such Contributions.

    6. Trademarks.

    This License does not grant permission to use the trade names, trademarks,
    service marks, or product names of the Licensor, except as required for
    reasonable and customary use in describing the origin of the Work and
    reproducing the content of the NOTICE file.

    7. Disclaimer of Warranty.

    Unless required by applicable law or agreed to in writing, Licensor provides the
    Work (and each Contributor provides its Contributions) on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied,
    including, without limitation, any warranties or conditions of TITLE,
    NON-INFRINGEMENT, MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE. You are
    solely responsible for determining the appropriateness of using or
    redistributing the Work and assume any risks associated with Your exercise of
    permissions under this License.

    8. Limitation of Liability.

    In no event and under no legal theory, whether in tort (including negligence),
    contract, or otherwise, unless required by applicable law (such as deliberate
    and grossly negligent acts) or agreed to in writing, shall any Contributor be
    liable to You for damages, including any direct, indirect, special, incidental,
    or consequential damages of any character arising as a result of this License or
    out of the use or inability to use the Work (including but not limited to
    damages for loss of goodwill, work stoppage, computer failure or malfunction, or
    any and all other commercial damages or losses), even if such Contributor has
    been advised of the possibility of such damages.

    9. Accepting Warranty or Additional Liability.

    While redistributing the Work or Derivative Works thereof, You may choose to
    offer, and charge a fee for, acceptance of support, warranty, indemnity, or
    other liability obligations and/or rights consistent with this License. However,
    in accepting such obligations, You may act only on Your own behalf and on Your
    sole responsibility, not on behalf of any other Contributor, and only if You
    agree to indemnify, defend, and hold each Contributor harmless for any liability
    incurred by, or claims asserted against, such Contributor by reason of your
    accepting any such warranty or additional liability.

    END OF TERMS AND CONDITIONS

    APPENDIX: How to apply the Apache License to your work

    To apply the Apache License to your work, attach the following boilerplate
    notice, with the fields enclosed by brackets "[]" replaced with your own
    identifying information. (Don't include the brackets!) The text should be
    enclosed in the appropriate comment syntax for the file format. We also
    recommend that a file or class name and description of purpose be included on
    the same "printed page" as the copyright notice for easier identification within
    third-party archives.

    Copyright [yyyy] [name of copyright owner]

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

</details>

---

[Stackoverflow answer for setting up axis in THREE.js](https://stackoverflow.com/a/44781658)
<details>
    <summary>License:</summary>

    Attribution-ShareAlike 4.0 International

    =======================================================================

    Creative Commons Corporation ("Creative Commons") is not a law firm and
    does not provide legal services or legal advice. Distribution of
    Creative Commons public licenses does not create a lawyer-client or
    other relationship. Creative Commons makes its licenses and related
    information available on an "as-is" basis. Creative Commons gives no
    warranties regarding its licenses, any material licensed under their
    terms and conditions, or any related information. Creative Commons
    disclaims all liability for damages resulting from their use to the
    fullest extent possible.

    Using Creative Commons Public Licenses

    Creative Commons public licenses provide a standard set of terms and
    conditions that creators and other rights holders may use to share
    original works of authorship and other material subject to copyright
    and certain other rights specified in the public license below. The
    following considerations are for informational purposes only, are not
    exhaustive, and do not form part of our licenses.

        Considerations for licensors: Our public licenses are
        intended for use by those authorized to give the public
        permission to use material in ways otherwise restricted by
        copyright and certain other rights. Our licenses are
        irrevocable. Licensors should read and understand the terms
        and conditions of the license they choose before applying it.
        Licensors should also secure all rights necessary before
        applying our licenses so that the public can reuse the
        material as expected. Licensors should clearly mark any
        material not subject to the license. This includes other CC-
        licensed material, or material used under an exception or
        limitation to copyright. More considerations for licensors:
        wiki.creativecommons.org/Considerations_for_licensors

        Considerations for the public: By using one of our public
        licenses, a licensor grants the public permission to use the
        licensed material under specified terms and conditions. If
        the licensor's permission is not necessary for any reason--for
        example, because of any applicable exception or limitation to
        copyright--then that use is not regulated by the license. Our
        licenses grant only permissions under copyright and certain
        other rights that a licensor has authority to grant. Use of
        the licensed material may still be restricted for other
        reasons, including because others have copyright or other
        rights in the material. A licensor may make special requests,
        such as asking that all changes be marked or described.
        Although not required by our licenses, you are encouraged to
        respect those requests where reasonable. More considerations
        for the public:
        wiki.creativecommons.org/Considerations_for_licensees

    =======================================================================

    Creative Commons Attribution-ShareAlike 4.0 International Public
    License

    By exercising the Licensed Rights (defined below), You accept and agree
    to be bound by the terms and conditions of this Creative Commons
    Attribution-ShareAlike 4.0 International Public License ("Public
    License"). To the extent this Public License may be interpreted as a
    contract, You are granted the Licensed Rights in consideration of Your
    acceptance of these terms and conditions, and the Licensor grants You
    such rights in consideration of benefits the Licensor receives from
    making the Licensed Material available under these terms and
    conditions.


    Section 1 -- Definitions.

    a. Adapted Material means material subject to Copyright and Similar
        Rights that is derived from or based upon the Licensed Material
        and in which the Licensed Material is translated, altered,
        arranged, transformed, or otherwise modified in a manner requiring
        permission under the Copyright and Similar Rights held by the
        Licensor. For purposes of this Public License, where the Licensed
        Material is a musical work, performance, or sound recording,
        Adapted Material is always produced where the Licensed Material is
        synched in timed relation with a moving image.

    b. Adapter's License means the license You apply to Your Copyright
        and Similar Rights in Your contributions to Adapted Material in
        accordance with the terms and conditions of this Public License.

    c. BY-SA Compatible License means a license listed at
        creativecommons.org/compatiblelicenses, approved by Creative
        Commons as essentially the equivalent of this Public License.

    d. Copyright and Similar Rights means copyright and/or similar rights
        closely related to copyright including, without limitation,
        performance, broadcast, sound recording, and Sui Generis Database
        Rights, without regard to how the rights are labeled or
        categorized. For purposes of this Public License, the rights
        specified in Section 2(b)(1)-(2) are not Copyright and Similar
        Rights.

    e. Effective Technological Measures means those measures that, in the
        absence of proper authority, may not be circumvented under laws
        fulfilling obligations under Article 11 of the WIPO Copyright
        Treaty adopted on December 20, 1996, and/or similar international
        agreements.

    f. Exceptions and Limitations means fair use, fair dealing, and/or
        any other exception or limitation to Copyright and Similar Rights
        that applies to Your use of the Licensed Material.

    g. License Elements means the license attributes listed in the name
        of a Creative Commons Public License. The License Elements of this
        Public License are Attribution and ShareAlike.

    h. Licensed Material means the artistic or literary work, database,
        or other material to which the Licensor applied this Public
        License.

    i. Licensed Rights means the rights granted to You subject to the
        terms and conditions of this Public License, which are limited to
        all Copyright and Similar Rights that apply to Your use of the
        Licensed Material and that the Licensor has authority to license.

    j. Licensor means the individual(s) or entity(ies) granting rights
        under this Public License.

    k. Share means to provide material to the public by any means or
        process that requires permission under the Licensed Rights, such
        as reproduction, public display, public performance, distribution,
        dissemination, communication, or importation, and to make material
        available to the public including in ways that members of the
        public may access the material from a place and at a time
        individually chosen by them.

    l. Sui Generis Database Rights means rights other than copyright
        resulting from Directive 96/9/EC of the European Parliament and of
        the Council of 11 March 1996 on the legal protection of databases,
        as amended and/or succeeded, as well as other essentially
        equivalent rights anywhere in the world.

    m. You means the individual or entity exercising the Licensed Rights
        under this Public License. Your has a corresponding meaning.


    Section 2 -- Scope.

    a. License grant.

        1. Subject to the terms and conditions of this Public License,
            the Licensor hereby grants You a worldwide, royalty-free,
            non-sublicensable, non-exclusive, irrevocable license to
            exercise the Licensed Rights in the Licensed Material to:

                a. reproduce and Share the Licensed Material, in whole or
                in part; and

                b. produce, reproduce, and Share Adapted Material.

        2. Exceptions and Limitations. For the avoidance of doubt, where
            Exceptions and Limitations apply to Your use, this Public
            License does not apply, and You do not need to comply with
            its terms and conditions.

        3. Term. The term of this Public License is specified in Section
            6(a).

        4. Media and formats; technical modifications allowed. The
            Licensor authorizes You to exercise the Licensed Rights in
            all media and formats whether now known or hereafter created,
            and to make technical modifications necessary to do so. The
            Licensor waives and/or agrees not to assert any right or
            authority to forbid You from making technical modifications
            necessary to exercise the Licensed Rights, including
            technical modifications necessary to circumvent Effective
            Technological Measures. For purposes of this Public License,
            simply making modifications authorized by this Section 2(a)
            (4) never produces Adapted Material.

        5. Downstream recipients.

                a. Offer from the Licensor -- Licensed Material. Every
                recipient of the Licensed Material automatically
                receives an offer from the Licensor to exercise the
                Licensed Rights under the terms and conditions of this
                Public License.

                b. Additional offer from the Licensor -- Adapted Material.
                Every recipient of Adapted Material from You
                automatically receives an offer from the Licensor to
                exercise the Licensed Rights in the Adapted Material
                under the conditions of the Adapter's License You apply.

                c. No downstream restrictions. You may not offer or impose
                any additional or different terms or conditions on, or
                apply any Effective Technological Measures to, the
                Licensed Material if doing so restricts exercise of the
                Licensed Rights by any recipient of the Licensed
                Material.

        6. No endorsement. Nothing in this Public License constitutes or
            may be construed as permission to assert or imply that You
            are, or that Your use of the Licensed Material is, connected
            with, or sponsored, endorsed, or granted official status by,
            the Licensor or others designated to receive attribution as
            provided in Section 3(a)(1)(A)(i).

    b. Other rights.

        1. Moral rights, such as the right of integrity, are not
            licensed under this Public License, nor are publicity,
            privacy, and/or other similar personality rights; however, to
            the extent possible, the Licensor waives and/or agrees not to
            assert any such rights held by the Licensor to the limited
            extent necessary to allow You to exercise the Licensed
            Rights, but not otherwise.

        2. Patent and trademark rights are not licensed under this
            Public License.

        3. To the extent possible, the Licensor waives any right to
            collect royalties from You for the exercise of the Licensed
            Rights, whether directly or through a collecting society
            under any voluntary or waivable statutory or compulsory
            licensing scheme. In all other cases the Licensor expressly
            reserves any right to collect such royalties.


    Section 3 -- License Conditions.

    Your exercise of the Licensed Rights is expressly made subject to the
    following conditions.

    a. Attribution.

        1. If You Share the Licensed Material (including in modified
            form), You must:

                a. retain the following if it is supplied by the Licensor
                with the Licensed Material:

                    i. identification of the creator(s) of the Licensed
                        Material and any others designated to receive
                        attribution, in any reasonable manner requested by
                        the Licensor (including by pseudonym if
                        designated);

                    ii. a copyright notice;

                iii. a notice that refers to this Public License;

                    iv. a notice that refers to the disclaimer of
                        warranties;

                    v. a URI or hyperlink to the Licensed Material to the
                        extent reasonably practicable;

                b. indicate if You modified the Licensed Material and
                retain an indication of any previous modifications; and

                c. indicate the Licensed Material is licensed under this
                Public License, and include the text of, or the URI or
                hyperlink to, this Public License.

        2. You may satisfy the conditions in Section 3(a)(1) in any
            reasonable manner based on the medium, means, and context in
            which You Share the Licensed Material. For example, it may be
            reasonable to satisfy the conditions by providing a URI or
            hyperlink to a resource that includes the required
            information.

        3. If requested by the Licensor, You must remove any of the
            information required by Section 3(a)(1)(A) to the extent
            reasonably practicable.

    b. ShareAlike.

        In addition to the conditions in Section 3(a), if You Share
        Adapted Material You produce, the following conditions also apply.

        1. The Adapter's License You apply must be a Creative Commons
            license with the same License Elements, this version or
            later, or a BY-SA Compatible License.

        2. You must include the text of, or the URI or hyperlink to, the
            Adapter's License You apply. You may satisfy this condition
            in any reasonable manner based on the medium, means, and
            context in which You Share Adapted Material.

        3. You may not offer or impose any additional or different terms
            or conditions on, or apply any Effective Technological
            Measures to, Adapted Material that restrict exercise of the
            rights granted under the Adapter's License You apply.


    Section 4 -- Sui Generis Database Rights.

    Where the Licensed Rights include Sui Generis Database Rights that
    apply to Your use of the Licensed Material:

    a. for the avoidance of doubt, Section 2(a)(1) grants You the right
        to extract, reuse, reproduce, and Share all or a substantial
        portion of the contents of the database;

    b. if You include all or a substantial portion of the database
        contents in a database in which You have Sui Generis Database
        Rights, then the database in which You have Sui Generis Database
        Rights (but not its individual contents) is Adapted Material,
        including for purposes of Section 3(b); and

    c. You must comply with the conditions in Section 3(a) if You Share
        all or a substantial portion of the contents of the database.

    For the avoidance of doubt, this Section 4 supplements and does not
    replace Your obligations under this Public License where the Licensed
    Rights include other Copyright and Similar Rights.


    Section 5 -- Disclaimer of Warranties and Limitation of Liability.

    a. UNLESS OTHERWISE SEPARATELY UNDERTAKEN BY THE LICENSOR, TO THE
        EXTENT POSSIBLE, THE LICENSOR OFFERS THE LICENSED MATERIAL AS-IS
        AND AS-AVAILABLE, AND MAKES NO REPRESENTATIONS OR WARRANTIES OF
        ANY KIND CONCERNING THE LICENSED MATERIAL, WHETHER EXPRESS,
        IMPLIED, STATUTORY, OR OTHER. THIS INCLUDES, WITHOUT LIMITATION,
        WARRANTIES OF TITLE, MERCHANTABILITY, FITNESS FOR A PARTICULAR
        PURPOSE, NON-INFRINGEMENT, ABSENCE OF LATENT OR OTHER DEFECTS,
        ACCURACY, OR THE PRESENCE OR ABSENCE OF ERRORS, WHETHER OR NOT
        KNOWN OR DISCOVERABLE. WHERE DISCLAIMERS OF WARRANTIES ARE NOT
        ALLOWED IN FULL OR IN PART, THIS DISCLAIMER MAY NOT APPLY TO YOU.

    b. TO THE EXTENT POSSIBLE, IN NO EVENT WILL THE LICENSOR BE LIABLE
        TO YOU ON ANY LEGAL THEORY (INCLUDING, WITHOUT LIMITATION,
        NEGLIGENCE) OR OTHERWISE FOR ANY DIRECT, SPECIAL, INDIRECT,
        INCIDENTAL, CONSEQUENTIAL, PUNITIVE, EXEMPLARY, OR OTHER LOSSES,
        COSTS, EXPENSES, OR DAMAGES ARISING OUT OF THIS PUBLIC LICENSE OR
        USE OF THE LICENSED MATERIAL, EVEN IF THE LICENSOR HAS BEEN
        ADVISED OF THE POSSIBILITY OF SUCH LOSSES, COSTS, EXPENSES, OR
        DAMAGES. WHERE A LIMITATION OF LIABILITY IS NOT ALLOWED IN FULL OR
        IN PART, THIS LIMITATION MAY NOT APPLY TO YOU.

    c. The disclaimer of warranties and limitation of liability provided
        above shall be interpreted in a manner that, to the extent
        possible, most closely approximates an absolute disclaimer and
        waiver of all liability.


    Section 6 -- Term and Termination.

    a. This Public License applies for the term of the Copyright and
        Similar Rights licensed here. However, if You fail to comply with
        this Public License, then Your rights under this Public License
        terminate automatically.

    b. Where Your right to use the Licensed Material has terminated under
        Section 6(a), it reinstates:

        1. automatically as of the date the violation is cured, provided
            it is cured within 30 days of Your discovery of the
            violation; or

        2. upon express reinstatement by the Licensor.

        For the avoidance of doubt, this Section 6(b) does not affect any
        right the Licensor may have to seek remedies for Your violations
        of this Public License.

    c. For the avoidance of doubt, the Licensor may also offer the
        Licensed Material under separate terms or conditions or stop
        distributing the Licensed Material at any time; however, doing so
        will not terminate this Public License.

    d. Sections 1, 5, 6, 7, and 8 survive termination of this Public
        License.


    Section 7 -- Other Terms and Conditions.

    a. The Licensor shall not be bound by any additional or different
        terms or conditions communicated by You unless expressly agreed.

    b. Any arrangements, understandings, or agreements regarding the
        Licensed Material not stated herein are separate from and
        independent of the terms and conditions of this Public License.


    Section 8 -- Interpretation.

    a. For the avoidance of doubt, this Public License does not, and
        shall not be interpreted to, reduce, limit, restrict, or impose
        conditions on any use of the Licensed Material that could lawfully
        be made without permission under this Public License.

    b. To the extent possible, if any provision of this Public License is
        deemed unenforceable, it shall be automatically reformed to the
        minimum extent necessary to make it enforceable. If the provision
        cannot be reformed, it shall be severed from this Public License
        without affecting the enforceability of the remaining terms and
        conditions.

    c. No term or condition of this Public License will be waived and no
        failure to comply consented to unless expressly agreed to by the
        Licensor.

    d. Nothing in this Public License constitutes or may be interpreted
        as a limitation upon, or waiver of, any privileges and immunities
        that apply to the Licensor or You, including from the legal
        processes of any jurisdiction or authority.


    =======================================================================

    Creative Commons is not a party to its public
    licenses. Notwithstanding, Creative Commons may elect to apply one of
    its public licenses to material it publishes and in those instances
    will be considered the “Licensor.” The text of the Creative Commons
    public licenses is dedicated to the public domain under the CC0 Public
    Domain Dedication. Except for the limited purpose of indicating that
    material is shared under a Creative Commons public license or as
    otherwise permitted by the Creative Commons policies published at
    creativecommons.org/policies, Creative Commons does not authorize the
    use of the trademark "Creative Commons" or any other trademark or logo
    of Creative Commons without its prior written consent including,
    without limitation, in connection with any unauthorized modifications
    to any of its public licenses or any other arrangements,
    understandings, or agreements concerning use of licensed material. For
    the avoidance of doubt, this paragraph does not form part of the
    public licenses.

    Creative Commons may be contacted at creativecommons.org.

</details>

---

[Stackoverflow answer for rotating an object in a circular path](https://gamedev.stackexchange.com/a/9610)
<details>
    <summary>License:</summary>

    Creative Commons Legal Code

    Attribution-ShareAlike 3.0 Unported

        CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
        LEGAL SERVICES. DISTRIBUTION OF THIS LICENSE DOES NOT CREATE AN
        ATTORNEY-CLIENT RELATIONSHIP. CREATIVE COMMONS PROVIDES THIS
        INFORMATION ON AN "AS-IS" BASIS. CREATIVE COMMONS MAKES NO WARRANTIES
        REGARDING THE INFORMATION PROVIDED, AND DISCLAIMS LIABILITY FOR
        DAMAGES RESULTING FROM ITS USE.

    License

    THE WORK (AS DEFINED BELOW) IS PROVIDED UNDER THE TERMS OF THIS CREATIVE
    COMMONS PUBLIC LICENSE ("CCPL" OR "LICENSE"). THE WORK IS PROTECTED BY
    COPYRIGHT AND/OR OTHER APPLICABLE LAW. ANY USE OF THE WORK OTHER THAN AS
    AUTHORIZED UNDER THIS LICENSE OR COPYRIGHT LAW IS PROHIBITED.

    BY EXERCISING ANY RIGHTS TO THE WORK PROVIDED HERE, YOU ACCEPT AND AGREE
    TO BE BOUND BY THE TERMS OF THIS LICENSE. TO THE EXTENT THIS LICENSE MAY
    BE CONSIDERED TO BE A CONTRACT, THE LICENSOR GRANTS YOU THE RIGHTS
    CONTAINED HERE IN CONSIDERATION OF YOUR ACCEPTANCE OF SUCH TERMS AND
    CONDITIONS.

    1. Definitions

    a. "Adaptation" means a work based upon the Work, or upon the Work and
        other pre-existing works, such as a translation, adaptation,
        derivative work, arrangement of music or other alterations of a
        literary or artistic work, or phonogram or performance and includes
        cinematographic adaptations or any other form in which the Work may be
        recast, transformed, or adapted including in any form recognizably
        derived from the original, except that a work that constitutes a
        Collection will not be considered an Adaptation for the purpose of
        this License. For the avoidance of doubt, where the Work is a musical
        work, performance or phonogram, the synchronization of the Work in
        timed-relation with a moving image ("synching") will be considered an
        Adaptation for the purpose of this License.
    b. "Collection" means a collection of literary or artistic works, such as
        encyclopedias and anthologies, or performances, phonograms or
        broadcasts, or other works or subject matter other than works listed
        in Section 1(f) below, which, by reason of the selection and
        arrangement of their contents, constitute intellectual creations, in
        which the Work is included in its entirety in unmodified form along
        with one or more other contributions, each constituting separate and
        independent works in themselves, which together are assembled into a
        collective whole. A work that constitutes a Collection will not be
        considered an Adaptation (as defined below) for the purposes of this
        License.
    c. "Creative Commons Compatible License" means a license that is listed
        at https://creativecommons.org/compatiblelicenses that has been
        approved by Creative Commons as being essentially equivalent to this
        License, including, at a minimum, because that license: (i) contains
        terms that have the same purpose, meaning and effect as the License
        Elements of this License; and, (ii) explicitly permits the relicensing
        of adaptations of works made available under that license under this
        License or a Creative Commons jurisdiction license with the same
        License Elements as this License.
    d. "Distribute" means to make available to the public the original and
        copies of the Work or Adaptation, as appropriate, through sale or
        other transfer of ownership.
    e. "License Elements" means the following high-level license attributes
        as selected by Licensor and indicated in the title of this License:
        Attribution, ShareAlike.
    f. "Licensor" means the individual, individuals, entity or entities that
        offer(s) the Work under the terms of this License.
    g. "Original Author" means, in the case of a literary or artistic work,
        the individual, individuals, entity or entities who created the Work
        or if no individual or entity can be identified, the publisher; and in
        addition (i) in the case of a performance the actors, singers,
        musicians, dancers, and other persons who act, sing, deliver, declaim,
        play in, interpret or otherwise perform literary or artistic works or
        expressions of folklore; (ii) in the case of a phonogram the producer
        being the person or legal entity who first fixes the sounds of a
        performance or other sounds; and, (iii) in the case of broadcasts, the
        organization that transmits the broadcast.
    h. "Work" means the literary and/or artistic work offered under the terms
        of this License including without limitation any production in the
        literary, scientific and artistic domain, whatever may be the mode or
        form of its expression including digital form, such as a book,
        pamphlet and other writing; a lecture, address, sermon or other work
        of the same nature; a dramatic or dramatico-musical work; a
        choreographic work or entertainment in dumb show; a musical
        composition with or without words; a cinematographic work to which are
        assimilated works expressed by a process analogous to cinematography;
        a work of drawing, painting, architecture, sculpture, engraving or
        lithography; a photographic work to which are assimilated works
        expressed by a process analogous to photography; a work of applied
        art; an illustration, map, plan, sketch or three-dimensional work
        relative to geography, topography, architecture or science; a
        performance; a broadcast; a phonogram; a compilation of data to the
        extent it is protected as a copyrightable work; or a work performed by
        a variety or circus performer to the extent it is not otherwise
        considered a literary or artistic work.
    i. "You" means an individual or entity exercising rights under this
        License who has not previously violated the terms of this License with
        respect to the Work, or who has received express permission from the
        Licensor to exercise rights under this License despite a previous
        violation.
    j. "Publicly Perform" means to perform public recitations of the Work and
        to communicate to the public those public recitations, by any means or
        process, including by wire or wireless means or public digital
        performances; to make available to the public Works in such a way that
        members of the public may access these Works from a place and at a
        place individually chosen by them; to perform the Work to the public
        by any means or process and the communication to the public of the
        performances of the Work, including by public digital performance; to
        broadcast and rebroadcast the Work by any means including signs,
        sounds or images.
    k. "Reproduce" means to make copies of the Work by any means including
        without limitation by sound or visual recordings and the right of
        fixation and reproducing fixations of the Work, including storage of a
        protected performance or phonogram in digital form or other electronic
        medium.

    2. Fair Dealing Rights. Nothing in this License is intended to reduce,
    limit, or restrict any uses free from copyright or rights arising from
    limitations or exceptions that are provided for in connection with the
    copyright protection under copyright law or other applicable laws.

    3. License Grant. Subject to the terms and conditions of this License,
    Licensor hereby grants You a worldwide, royalty-free, non-exclusive,
    perpetual (for the duration of the applicable copyright) license to
    exercise the rights in the Work as stated below:

    a. to Reproduce the Work, to incorporate the Work into one or more
        Collections, and to Reproduce the Work as incorporated in the
        Collections;
    b. to create and Reproduce Adaptations provided that any such Adaptation,
        including any translation in any medium, takes reasonable steps to
        clearly label, demarcate or otherwise identify that changes were made
        to the original Work. For example, a translation could be marked "The
        original work was translated from English to Spanish," or a
        modification could indicate "The original work has been modified.";
    c. to Distribute and Publicly Perform the Work including as incorporated
        in Collections; and,
    d. to Distribute and Publicly Perform Adaptations.
    e. For the avoidance of doubt:

        i. Non-waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme cannot be waived, the Licensor
            reserves the exclusive right to collect such royalties for any
            exercise by You of the rights granted under this License;
        ii. Waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme can be waived, the Licensor waives the
            exclusive right to collect such royalties for any exercise by You
            of the rights granted under this License; and,
    iii. Voluntary License Schemes. The Licensor waives the right to
            collect royalties, whether individually or, in the event that the
            Licensor is a member of a collecting society that administers
            voluntary licensing schemes, via that society, from any exercise
            by You of the rights granted under this License.

    The above rights may be exercised in all media and formats whether now
    known or hereafter devised. The above rights include the right to make
    such modifications as are technically necessary to exercise the rights in
    other media and formats. Subject to Section 8(f), all rights not expressly
    granted by Licensor are hereby reserved.

    4. Restrictions. The license granted in Section 3 above is expressly made
    subject to and limited by the following restrictions:

    a. You may Distribute or Publicly Perform the Work only under the terms
        of this License. You must include a copy of, or the Uniform Resource
        Identifier (URI) for, this License with every copy of the Work You
        Distribute or Publicly Perform. You may not offer or impose any terms
        on the Work that restrict the terms of this License or the ability of
        the recipient of the Work to exercise the rights granted to that
        recipient under the terms of the License. You may not sublicense the
        Work. You must keep intact all notices that refer to this License and
        to the disclaimer of warranties with every copy of the Work You
        Distribute or Publicly Perform. When You Distribute or Publicly
        Perform the Work, You may not impose any effective technological
        measures on the Work that restrict the ability of a recipient of the
        Work from You to exercise the rights granted to that recipient under
        the terms of the License. This Section 4(a) applies to the Work as
        incorporated in a Collection, but this does not require the Collection
        apart from the Work itself to be made subject to the terms of this
        License. If You create a Collection, upon notice from any Licensor You
        must, to the extent practicable, remove from the Collection any credit
        as required by Section 4(c), as requested. If You create an
        Adaptation, upon notice from any Licensor You must, to the extent
        practicable, remove from the Adaptation any credit as required by
        Section 4(c), as requested.
    b. You may Distribute or Publicly Perform an Adaptation only under the
        terms of: (i) this License; (ii) a later version of this License with
        the same License Elements as this License; (iii) a Creative Commons
        jurisdiction license (either this or a later license version) that
        contains the same License Elements as this License (e.g.,
        Attribution-ShareAlike 3.0 US)); (iv) a Creative Commons Compatible
        License. If you license the Adaptation under one of the licenses
        mentioned in (iv), you must comply with the terms of that license. If
        you license the Adaptation under the terms of any of the licenses
        mentioned in (i), (ii) or (iii) (the "Applicable License"), you must
        comply with the terms of the Applicable License generally and the
        following provisions: (I) You must include a copy of, or the URI for,
        the Applicable License with every copy of each Adaptation You
        Distribute or Publicly Perform; (II) You may not offer or impose any
        terms on the Adaptation that restrict the terms of the Applicable
        License or the ability of the recipient of the Adaptation to exercise
        the rights granted to that recipient under the terms of the Applicable
        License; (III) You must keep intact all notices that refer to the
        Applicable License and to the disclaimer of warranties with every copy
        of the Work as included in the Adaptation You Distribute or Publicly
        Perform; (IV) when You Distribute or Publicly Perform the Adaptation,
        You may not impose any effective technological measures on the
        Adaptation that restrict the ability of a recipient of the Adaptation
        from You to exercise the rights granted to that recipient under the
        terms of the Applicable License. This Section 4(b) applies to the
        Adaptation as incorporated in a Collection, but this does not require
        the Collection apart from the Adaptation itself to be made subject to
        the terms of the Applicable License.
    c. If You Distribute, or Publicly Perform the Work or any Adaptations or
        Collections, You must, unless a request has been made pursuant to
        Section 4(a), keep intact all copyright notices for the Work and
        provide, reasonable to the medium or means You are utilizing: (i) the
        name of the Original Author (or pseudonym, if applicable) if supplied,
        and/or if the Original Author and/or Licensor designate another party
        or parties (e.g., a sponsor institute, publishing entity, journal) for
        attribution ("Attribution Parties") in Licensor's copyright notice,
        terms of service or by other reasonable means, the name of such party
        or parties; (ii) the title of the Work if supplied; (iii) to the
        extent reasonably practicable, the URI, if any, that Licensor
        specifies to be associated with the Work, unless such URI does not
        refer to the copyright notice or licensing information for the Work;
        and (iv) , consistent with Ssection 3(b), in the case of an
        Adaptation, a credit identifying the use of the Work in the Adaptation
        (e.g., "French translation of the Work by Original Author," or
        "Screenplay based on original Work by Original Author"). The credit
        required by this Section 4(c) may be implemented in any reasonable
        manner; provided, however, that in the case of a Adaptation or
        Collection, at a minimum such credit will appear, if a credit for all
        contributing authors of the Adaptation or Collection appears, then as
        part of these credits and in a manner at least as prominent as the
        credits for the other contributing authors. For the avoidance of
        doubt, You may only use the credit required by this Section for the
        purpose of attribution in the manner set out above and, by exercising
        Your rights under this License, You may not implicitly or explicitly
        assert or imply any connection with, sponsorship or endorsement by the
        Original Author, Licensor and/or Attribution Parties, as appropriate,
        of You or Your use of the Work, without the separate, express prior
        written permission of the Original Author, Licensor and/or Attribution
        Parties.
    d. Except as otherwise agreed in writing by the Licensor or as may be
        otherwise permitted by applicable law, if You Reproduce, Distribute or
        Publicly Perform the Work either by itself or as part of any
        Adaptations or Collections, You must not distort, mutilate, modify or
        take other derogatory action in relation to the Work which would be
        prejudicial to the Original Author's honor or reputation. Licensor
        agrees that in those jurisdictions (e.g. Japan), in which any exercise
        of the right granted in Section 3(b) of this License (the right to
        make Adaptations) would be deemed to be a distortion, mutilation,
        modification or other derogatory action prejudicial to the Original
        Author's honor and reputation, the Licensor will waive or not assert,
        as appropriate, this Section, to the fullest extent permitted by the
        applicable national law, to enable You to reasonably exercise Your
        right under Section 3(b) of this License (right to make Adaptations)
        but not otherwise.

    5. Representations, Warranties and Disclaimer

    UNLESS OTHERWISE MUTUALLY AGREED TO BY THE PARTIES IN WRITING, LICENSOR
    OFFERS THE WORK AS-IS AND MAKES NO REPRESENTATIONS OR WARRANTIES OF ANY
    KIND CONCERNING THE WORK, EXPRESS, IMPLIED, STATUTORY OR OTHERWISE,
    INCLUDING, WITHOUT LIMITATION, WARRANTIES OF TITLE, MERCHANTIBILITY,
    FITNESS FOR A PARTICULAR PURPOSE, NONINFRINGEMENT, OR THE ABSENCE OF
    LATENT OR OTHER DEFECTS, ACCURACY, OR THE PRESENCE OF ABSENCE OF ERRORS,
    WHETHER OR NOT DISCOVERABLE. SOME JURISDICTIONS DO NOT ALLOW THE EXCLUSION
    OF IMPLIED WARRANTIES, SO SUCH EXCLUSION MAY NOT APPLY TO YOU.

    6. Limitation on Liability. EXCEPT TO THE EXTENT REQUIRED BY APPLICABLE
    LAW, IN NO EVENT WILL LICENSOR BE LIABLE TO YOU ON ANY LEGAL THEORY FOR
    ANY SPECIAL, INCIDENTAL, CONSEQUENTIAL, PUNITIVE OR EXEMPLARY DAMAGES
    ARISING OUT OF THIS LICENSE OR THE USE OF THE WORK, EVEN IF LICENSOR HAS
    BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

    7. Termination

    a. This License and the rights granted hereunder will terminate
        automatically upon any breach by You of the terms of this License.
        Individuals or entities who have received Adaptations or Collections
        from You under this License, however, will not have their licenses
        terminated provided such individuals or entities remain in full
        compliance with those licenses. Sections 1, 2, 5, 6, 7, and 8 will
        survive any termination of this License.
    b. Subject to the above terms and conditions, the license granted here is
        perpetual (for the duration of the applicable copyright in the Work).
        Notwithstanding the above, Licensor reserves the right to release the
        Work under different license terms or to stop distributing the Work at
        any time; provided, however that any such election will not serve to
        withdraw this License (or any other license that has been, or is
        required to be, granted under the terms of this License), and this
        License will continue in full force and effect unless terminated as
        stated above.

    8. Miscellaneous

    a. Each time You Distribute or Publicly Perform the Work or a Collection,
        the Licensor offers to the recipient a license to the Work on the same
        terms and conditions as the license granted to You under this License.
    b. Each time You Distribute or Publicly Perform an Adaptation, Licensor
        offers to the recipient a license to the original Work on the same
        terms and conditions as the license granted to You under this License.
    c. If any provision of this License is invalid or unenforceable under
        applicable law, it shall not affect the validity or enforceability of
        the remainder of the terms of this License, and without further action
        by the parties to this agreement, such provision shall be reformed to
        the minimum extent necessary to make such provision valid and
        enforceable.
    d. No term or provision of this License shall be deemed waived and no
        breach consented to unless such waiver or consent shall be in writing
        and signed by the party to be charged with such waiver or consent.
    e. This License constitutes the entire agreement between the parties with
        respect to the Work licensed here. There are no understandings,
        agreements or representations with respect to the Work not specified
        here. Licensor shall not be bound by any additional provisions that
        may appear in any communication from You. This License may not be
        modified without the mutual written agreement of the Licensor and You.
    f. The rights granted under, and the subject matter referenced, in this
        License were drafted utilizing the terminology of the Berne Convention
        for the Protection of Literary and Artistic Works (as amended on
        September 28, 1979), the Rome Convention of 1961, the WIPO Copyright
        Treaty of 1996, the WIPO Performances and Phonograms Treaty of 1996
        and the Universal Copyright Convention (as revised on July 24, 1971).
        These rights and subject matter take effect in the relevant
        jurisdiction in which the License terms are sought to be enforced
        according to the corresponding provisions of the implementation of
        those treaty provisions in the applicable national law. If the
        standard suite of rights granted under applicable copyright law
        includes additional rights not granted under this License, such
        additional rights are deemed to be included in the License; this
        License is not intended to restrict the license of any rights under
        applicable law.


    Creative Commons Notice

        Creative Commons is not a party to this License, and makes no warranty
        whatsoever in connection with the Work. Creative Commons will not be
        liable to You or any party on any legal theory for any damages
        whatsoever, including without limitation any general, special,
        incidental or consequential damages arising in connection to this
        license. Notwithstanding the foregoing two (2) sentences, if Creative
        Commons has expressly identified itself as the Licensor hereunder, it
        shall have all rights and obligations of Licensor.

        Except for the limited purpose of indicating to the public that the
        Work is licensed under the CCPL, Creative Commons does not authorize
        the use by either party of the trademark "Creative Commons" or any
        related trademark or logo of Creative Commons without the prior
        written consent of Creative Commons. Any permitted use will be in
        compliance with Creative Commons' then-current trademark usage
        guidelines, as may be published on its website or otherwise made
        available upon request from time to time. For the avoidance of doubt,
        this trademark restriction does not form part of the License.

        Creative Commons may be contacted at https://creativecommons.org/.

</details>

---

[Stackoverflow answer for double sided THREE.js rendering.](https://stackoverflow.com/a/26471195)
<details>
    <summary>License:</summary>

    Creative Commons Legal Code

    Attribution-ShareAlike 3.0 Unported

        CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
        LEGAL SERVICES. DISTRIBUTION OF THIS LICENSE DOES NOT CREATE AN
        ATTORNEY-CLIENT RELATIONSHIP. CREATIVE COMMONS PROVIDES THIS
        INFORMATION ON AN "AS-IS" BASIS. CREATIVE COMMONS MAKES NO WARRANTIES
        REGARDING THE INFORMATION PROVIDED, AND DISCLAIMS LIABILITY FOR
        DAMAGES RESULTING FROM ITS USE.

    License

    THE WORK (AS DEFINED BELOW) IS PROVIDED UNDER THE TERMS OF THIS CREATIVE
    COMMONS PUBLIC LICENSE ("CCPL" OR "LICENSE"). THE WORK IS PROTECTED BY
    COPYRIGHT AND/OR OTHER APPLICABLE LAW. ANY USE OF THE WORK OTHER THAN AS
    AUTHORIZED UNDER THIS LICENSE OR COPYRIGHT LAW IS PROHIBITED.

    BY EXERCISING ANY RIGHTS TO THE WORK PROVIDED HERE, YOU ACCEPT AND AGREE
    TO BE BOUND BY THE TERMS OF THIS LICENSE. TO THE EXTENT THIS LICENSE MAY
    BE CONSIDERED TO BE A CONTRACT, THE LICENSOR GRANTS YOU THE RIGHTS
    CONTAINED HERE IN CONSIDERATION OF YOUR ACCEPTANCE OF SUCH TERMS AND
    CONDITIONS.

    1. Definitions

    a. "Adaptation" means a work based upon the Work, or upon the Work and
        other pre-existing works, such as a translation, adaptation,
        derivative work, arrangement of music or other alterations of a
        literary or artistic work, or phonogram or performance and includes
        cinematographic adaptations or any other form in which the Work may be
        recast, transformed, or adapted including in any form recognizably
        derived from the original, except that a work that constitutes a
        Collection will not be considered an Adaptation for the purpose of
        this License. For the avoidance of doubt, where the Work is a musical
        work, performance or phonogram, the synchronization of the Work in
        timed-relation with a moving image ("synching") will be considered an
        Adaptation for the purpose of this License.
    b. "Collection" means a collection of literary or artistic works, such as
        encyclopedias and anthologies, or performances, phonograms or
        broadcasts, or other works or subject matter other than works listed
        in Section 1(f) below, which, by reason of the selection and
        arrangement of their contents, constitute intellectual creations, in
        which the Work is included in its entirety in unmodified form along
        with one or more other contributions, each constituting separate and
        independent works in themselves, which together are assembled into a
        collective whole. A work that constitutes a Collection will not be
        considered an Adaptation (as defined below) for the purposes of this
        License.
    c. "Creative Commons Compatible License" means a license that is listed
        at https://creativecommons.org/compatiblelicenses that has been
        approved by Creative Commons as being essentially equivalent to this
        License, including, at a minimum, because that license: (i) contains
        terms that have the same purpose, meaning and effect as the License
        Elements of this License; and, (ii) explicitly permits the relicensing
        of adaptations of works made available under that license under this
        License or a Creative Commons jurisdiction license with the same
        License Elements as this License.
    d. "Distribute" means to make available to the public the original and
        copies of the Work or Adaptation, as appropriate, through sale or
        other transfer of ownership.
    e. "License Elements" means the following high-level license attributes
        as selected by Licensor and indicated in the title of this License:
        Attribution, ShareAlike.
    f. "Licensor" means the individual, individuals, entity or entities that
        offer(s) the Work under the terms of this License.
    g. "Original Author" means, in the case of a literary or artistic work,
        the individual, individuals, entity or entities who created the Work
        or if no individual or entity can be identified, the publisher; and in
        addition (i) in the case of a performance the actors, singers,
        musicians, dancers, and other persons who act, sing, deliver, declaim,
        play in, interpret or otherwise perform literary or artistic works or
        expressions of folklore; (ii) in the case of a phonogram the producer
        being the person or legal entity who first fixes the sounds of a
        performance or other sounds; and, (iii) in the case of broadcasts, the
        organization that transmits the broadcast.
    h. "Work" means the literary and/or artistic work offered under the terms
        of this License including without limitation any production in the
        literary, scientific and artistic domain, whatever may be the mode or
        form of its expression including digital form, such as a book,
        pamphlet and other writing; a lecture, address, sermon or other work
        of the same nature; a dramatic or dramatico-musical work; a
        choreographic work or entertainment in dumb show; a musical
        composition with or without words; a cinematographic work to which are
        assimilated works expressed by a process analogous to cinematography;
        a work of drawing, painting, architecture, sculpture, engraving or
        lithography; a photographic work to which are assimilated works
        expressed by a process analogous to photography; a work of applied
        art; an illustration, map, plan, sketch or three-dimensional work
        relative to geography, topography, architecture or science; a
        performance; a broadcast; a phonogram; a compilation of data to the
        extent it is protected as a copyrightable work; or a work performed by
        a variety or circus performer to the extent it is not otherwise
        considered a literary or artistic work.
    i. "You" means an individual or entity exercising rights under this
        License who has not previously violated the terms of this License with
        respect to the Work, or who has received express permission from the
        Licensor to exercise rights under this License despite a previous
        violation.
    j. "Publicly Perform" means to perform public recitations of the Work and
        to communicate to the public those public recitations, by any means or
        process, including by wire or wireless means or public digital
        performances; to make available to the public Works in such a way that
        members of the public may access these Works from a place and at a
        place individually chosen by them; to perform the Work to the public
        by any means or process and the communication to the public of the
        performances of the Work, including by public digital performance; to
        broadcast and rebroadcast the Work by any means including signs,
        sounds or images.
    k. "Reproduce" means to make copies of the Work by any means including
        without limitation by sound or visual recordings and the right of
        fixation and reproducing fixations of the Work, including storage of a
        protected performance or phonogram in digital form or other electronic
        medium.

    2. Fair Dealing Rights. Nothing in this License is intended to reduce,
    limit, or restrict any uses free from copyright or rights arising from
    limitations or exceptions that are provided for in connection with the
    copyright protection under copyright law or other applicable laws.

    3. License Grant. Subject to the terms and conditions of this License,
    Licensor hereby grants You a worldwide, royalty-free, non-exclusive,
    perpetual (for the duration of the applicable copyright) license to
    exercise the rights in the Work as stated below:

    a. to Reproduce the Work, to incorporate the Work into one or more
        Collections, and to Reproduce the Work as incorporated in the
        Collections;
    b. to create and Reproduce Adaptations provided that any such Adaptation,
        including any translation in any medium, takes reasonable steps to
        clearly label, demarcate or otherwise identify that changes were made
        to the original Work. For example, a translation could be marked "The
        original work was translated from English to Spanish," or a
        modification could indicate "The original work has been modified.";
    c. to Distribute and Publicly Perform the Work including as incorporated
        in Collections; and,
    d. to Distribute and Publicly Perform Adaptations.
    e. For the avoidance of doubt:

        i. Non-waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme cannot be waived, the Licensor
            reserves the exclusive right to collect such royalties for any
            exercise by You of the rights granted under this License;
        ii. Waivable Compulsory License Schemes. In those jurisdictions in
            which the right to collect royalties through any statutory or
            compulsory licensing scheme can be waived, the Licensor waives the
            exclusive right to collect such royalties for any exercise by You
            of the rights granted under this License; and,
    iii. Voluntary License Schemes. The Licensor waives the right to
            collect royalties, whether individually or, in the event that the
            Licensor is a member of a collecting society that administers
            voluntary licensing schemes, via that society, from any exercise
            by You of the rights granted under this License.

    The above rights may be exercised in all media and formats whether now
    known or hereafter devised. The above rights include the right to make
    such modifications as are technically necessary to exercise the rights in
    other media and formats. Subject to Section 8(f), all rights not expressly
    granted by Licensor are hereby reserved.

    4. Restrictions. The license granted in Section 3 above is expressly made
    subject to and limited by the following restrictions:

    a. You may Distribute or Publicly Perform the Work only under the terms
        of this License. You must include a copy of, or the Uniform Resource
        Identifier (URI) for, this License with every copy of the Work You
        Distribute or Publicly Perform. You may not offer or impose any terms
        on the Work that restrict the terms of this License or the ability of
        the recipient of the Work to exercise the rights granted to that
        recipient under the terms of the License. You may not sublicense the
        Work. You must keep intact all notices that refer to this License and
        to the disclaimer of warranties with every copy of the Work You
        Distribute or Publicly Perform. When You Distribute or Publicly
        Perform the Work, You may not impose any effective technological
        measures on the Work that restrict the ability of a recipient of the
        Work from You to exercise the rights granted to that recipient under
        the terms of the License. This Section 4(a) applies to the Work as
        incorporated in a Collection, but this does not require the Collection
        apart from the Work itself to be made subject to the terms of this
        License. If You create a Collection, upon notice from any Licensor You
        must, to the extent practicable, remove from the Collection any credit
        as required by Section 4(c), as requested. If You create an
        Adaptation, upon notice from any Licensor You must, to the extent
        practicable, remove from the Adaptation any credit as required by
        Section 4(c), as requested.
    b. You may Distribute or Publicly Perform an Adaptation only under the
        terms of: (i) this License; (ii) a later version of this License with
        the same License Elements as this License; (iii) a Creative Commons
        jurisdiction license (either this or a later license version) that
        contains the same License Elements as this License (e.g.,
        Attribution-ShareAlike 3.0 US)); (iv) a Creative Commons Compatible
        License. If you license the Adaptation under one of the licenses
        mentioned in (iv), you must comply with the terms of that license. If
        you license the Adaptation under the terms of any of the licenses
        mentioned in (i), (ii) or (iii) (the "Applicable License"), you must
        comply with the terms of the Applicable License generally and the
        following provisions: (I) You must include a copy of, or the URI for,
        the Applicable License with every copy of each Adaptation You
        Distribute or Publicly Perform; (II) You may not offer or impose any
        terms on the Adaptation that restrict the terms of the Applicable
        License or the ability of the recipient of the Adaptation to exercise
        the rights granted to that recipient under the terms of the Applicable
        License; (III) You must keep intact all notices that refer to the
        Applicable License and to the disclaimer of warranties with every copy
        of the Work as included in the Adaptation You Distribute or Publicly
        Perform; (IV) when You Distribute or Publicly Perform the Adaptation,
        You may not impose any effective technological measures on the
        Adaptation that restrict the ability of a recipient of the Adaptation
        from You to exercise the rights granted to that recipient under the
        terms of the Applicable License. This Section 4(b) applies to the
        Adaptation as incorporated in a Collection, but this does not require
        the Collection apart from the Adaptation itself to be made subject to
        the terms of the Applicable License.
    c. If You Distribute, or Publicly Perform the Work or any Adaptations or
        Collections, You must, unless a request has been made pursuant to
        Section 4(a), keep intact all copyright notices for the Work and
        provide, reasonable to the medium or means You are utilizing: (i) the
        name of the Original Author (or pseudonym, if applicable) if supplied,
        and/or if the Original Author and/or Licensor designate another party
        or parties (e.g., a sponsor institute, publishing entity, journal) for
        attribution ("Attribution Parties") in Licensor's copyright notice,
        terms of service or by other reasonable means, the name of such party
        or parties; (ii) the title of the Work if supplied; (iii) to the
        extent reasonably practicable, the URI, if any, that Licensor
        specifies to be associated with the Work, unless such URI does not
        refer to the copyright notice or licensing information for the Work;
        and (iv) , consistent with Ssection 3(b), in the case of an
        Adaptation, a credit identifying the use of the Work in the Adaptation
        (e.g., "French translation of the Work by Original Author," or
        "Screenplay based on original Work by Original Author"). The credit
        required by this Section 4(c) may be implemented in any reasonable
        manner; provided, however, that in the case of a Adaptation or
        Collection, at a minimum such credit will appear, if a credit for all
        contributing authors of the Adaptation or Collection appears, then as
        part of these credits and in a manner at least as prominent as the
        credits for the other contributing authors. For the avoidance of
        doubt, You may only use the credit required by this Section for the
        purpose of attribution in the manner set out above and, by exercising
        Your rights under this License, You may not implicitly or explicitly
        assert or imply any connection with, sponsorship or endorsement by the
        Original Author, Licensor and/or Attribution Parties, as appropriate,
        of You or Your use of the Work, without the separate, express prior
        written permission of the Original Author, Licensor and/or Attribution
        Parties.
    d. Except as otherwise agreed in writing by the Licensor or as may be
        otherwise permitted by applicable law, if You Reproduce, Distribute or
        Publicly Perform the Work either by itself or as part of any
        Adaptations or Collections, You must not distort, mutilate, modify or
        take other derogatory action in relation to the Work which would be
        prejudicial to the Original Author's honor or reputation. Licensor
        agrees that in those jurisdictions (e.g. Japan), in which any exercise
        of the right granted in Section 3(b) of this License (the right to
        make Adaptations) would be deemed to be a distortion, mutilation,
        modification or other derogatory action prejudicial to the Original
        Author's honor and reputation, the Licensor will waive or not assert,
        as appropriate, this Section, to the fullest extent permitted by the
        applicable national law, to enable You to reasonably exercise Your
        right under Section 3(b) of this License (right to make Adaptations)
        but not otherwise.

    5. Representations, Warranties and Disclaimer

    UNLESS OTHERWISE MUTUALLY AGREED TO BY THE PARTIES IN WRITING, LICENSOR
    OFFERS THE WORK AS-IS AND MAKES NO REPRESENTATIONS OR WARRANTIES OF ANY
    KIND CONCERNING THE WORK, EXPRESS, IMPLIED, STATUTORY OR OTHERWISE,
    INCLUDING, WITHOUT LIMITATION, WARRANTIES OF TITLE, MERCHANTIBILITY,
    FITNESS FOR A PARTICULAR PURPOSE, NONINFRINGEMENT, OR THE ABSENCE OF
    LATENT OR OTHER DEFECTS, ACCURACY, OR THE PRESENCE OF ABSENCE OF ERRORS,
    WHETHER OR NOT DISCOVERABLE. SOME JURISDICTIONS DO NOT ALLOW THE EXCLUSION
    OF IMPLIED WARRANTIES, SO SUCH EXCLUSION MAY NOT APPLY TO YOU.

    6. Limitation on Liability. EXCEPT TO THE EXTENT REQUIRED BY APPLICABLE
    LAW, IN NO EVENT WILL LICENSOR BE LIABLE TO YOU ON ANY LEGAL THEORY FOR
    ANY SPECIAL, INCIDENTAL, CONSEQUENTIAL, PUNITIVE OR EXEMPLARY DAMAGES
    ARISING OUT OF THIS LICENSE OR THE USE OF THE WORK, EVEN IF LICENSOR HAS
    BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

    7. Termination

    a. This License and the rights granted hereunder will terminate
        automatically upon any breach by You of the terms of this License.
        Individuals or entities who have received Adaptations or Collections
        from You under this License, however, will not have their licenses
        terminated provided such individuals or entities remain in full
        compliance with those licenses. Sections 1, 2, 5, 6, 7, and 8 will
        survive any termination of this License.
    b. Subject to the above terms and conditions, the license granted here is
        perpetual (for the duration of the applicable copyright in the Work).
        Notwithstanding the above, Licensor reserves the right to release the
        Work under different license terms or to stop distributing the Work at
        any time; provided, however that any such election will not serve to
        withdraw this License (or any other license that has been, or is
        required to be, granted under the terms of this License), and this
        License will continue in full force and effect unless terminated as
        stated above.

    8. Miscellaneous

    a. Each time You Distribute or Publicly Perform the Work or a Collection,
        the Licensor offers to the recipient a license to the Work on the same
        terms and conditions as the license granted to You under this License.
    b. Each time You Distribute or Publicly Perform an Adaptation, Licensor
        offers to the recipient a license to the original Work on the same
        terms and conditions as the license granted to You under this License.
    c. If any provision of this License is invalid or unenforceable under
        applicable law, it shall not affect the validity or enforceability of
        the remainder of the terms of this License, and without further action
        by the parties to this agreement, such provision shall be reformed to
        the minimum extent necessary to make such provision valid and
        enforceable.
    d. No term or provision of this License shall be deemed waived and no
        breach consented to unless such waiver or consent shall be in writing
        and signed by the party to be charged with such waiver or consent.
    e. This License constitutes the entire agreement between the parties with
        respect to the Work licensed here. There are no understandings,
        agreements or representations with respect to the Work not specified
        here. Licensor shall not be bound by any additional provisions that
        may appear in any communication from You. This License may not be
        modified without the mutual written agreement of the Licensor and You.
    f. The rights granted under, and the subject matter referenced, in this
        License were drafted utilizing the terminology of the Berne Convention
        for the Protection of Literary and Artistic Works (as amended on
        September 28, 1979), the Rome Convention of 1961, the WIPO Copyright
        Treaty of 1996, the WIPO Performances and Phonograms Treaty of 1996
        and the Universal Copyright Convention (as revised on July 24, 1971).
        These rights and subject matter take effect in the relevant
        jurisdiction in which the License terms are sought to be enforced
        according to the corresponding provisions of the implementation of
        those treaty provisions in the applicable national law. If the
        standard suite of rights granted under applicable copyright law
        includes additional rights not granted under this License, such
        additional rights are deemed to be included in the License; this
        License is not intended to restrict the license of any rights under
        applicable law.


    Creative Commons Notice

        Creative Commons is not a party to this License, and makes no warranty
        whatsoever in connection with the Work. Creative Commons will not be
        liable to You or any party on any legal theory for any damages
        whatsoever, including without limitation any general, special,
        incidental or consequential damages arising in connection to this
        license. Notwithstanding the foregoing two (2) sentences, if Creative
        Commons has expressly identified itself as the Licensor hereunder, it
        shall have all rights and obligations of Licensor.

        Except for the limited purpose of indicating to the public that the
        Work is licensed under the CCPL, Creative Commons does not authorize
        the use by either party of the trademark "Creative Commons" or any
        related trademark or logo of Creative Commons without the prior
        written consent of Creative Commons. Any permitted use will be in
        compliance with Creative Commons' then-current trademark usage
        guidelines, as may be published on its website or otherwise made
        available upon request from time to time. For the avoidance of doubt,
        this trademark restriction does not form part of the License.

        Creative Commons may be contacted at https://creativecommons.org/.

</details>

---

[THREE.js](https://github.com/mrdoob/three.js)
<details>
    <summary>THREE.js's License</summary>

    The MIT License

    Copyright © 2010-2023 three.js authors

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.

</details>

---

[Stackoverflow answer on delay function](https://stackoverflow.com/a/47480429) and 
[Stackoverflow comment on delay function answer](https://stackoverflow.com/questions/14226803/wait-5-seconds-before-executing-next-line#comment114272794_47480429)
<details>
    <summary>License</summary>

    Attribution-ShareAlike 4.0 International

    =======================================================================

    Creative Commons Corporation ("Creative Commons") is not a law firm and
    does not provide legal services or legal advice. Distribution of
    Creative Commons public licenses does not create a lawyer-client or
    other relationship. Creative Commons makes its licenses and related
    information available on an "as-is" basis. Creative Commons gives no
    warranties regarding its licenses, any material licensed under their
    terms and conditions, or any related information. Creative Commons
    disclaims all liability for damages resulting from their use to the
    fullest extent possible.

    Using Creative Commons Public Licenses

    Creative Commons public licenses provide a standard set of terms and
    conditions that creators and other rights holders may use to share
    original works of authorship and other material subject to copyright
    and certain other rights specified in the public license below. The
    following considerations are for informational purposes only, are not
    exhaustive, and do not form part of our licenses.

        Considerations for licensors: Our public licenses are
        intended for use by those authorized to give the public
        permission to use material in ways otherwise restricted by
        copyright and certain other rights. Our licenses are
        irrevocable. Licensors should read and understand the terms
        and conditions of the license they choose before applying it.
        Licensors should also secure all rights necessary before
        applying our licenses so that the public can reuse the
        material as expected. Licensors should clearly mark any
        material not subject to the license. This includes other CC-
        licensed material, or material used under an exception or
        limitation to copyright. More considerations for licensors:
        wiki.creativecommons.org/Considerations_for_licensors

        Considerations for the public: By using one of our public
        licenses, a licensor grants the public permission to use the
        licensed material under specified terms and conditions. If
        the licensor's permission is not necessary for any reason--for
        example, because of any applicable exception or limitation to
        copyright--then that use is not regulated by the license. Our
        licenses grant only permissions under copyright and certain
        other rights that a licensor has authority to grant. Use of
        the licensed material may still be restricted for other
        reasons, including because others have copyright or other
        rights in the material. A licensor may make special requests,
        such as asking that all changes be marked or described.
        Although not required by our licenses, you are encouraged to
        respect those requests where reasonable. More considerations
        for the public:
        wiki.creativecommons.org/Considerations_for_licensees

    =======================================================================

    Creative Commons Attribution-ShareAlike 4.0 International Public
    License

    By exercising the Licensed Rights (defined below), You accept and agree
    to be bound by the terms and conditions of this Creative Commons
    Attribution-ShareAlike 4.0 International Public License ("Public
    License"). To the extent this Public License may be interpreted as a
    contract, You are granted the Licensed Rights in consideration of Your
    acceptance of these terms and conditions, and the Licensor grants You
    such rights in consideration of benefits the Licensor receives from
    making the Licensed Material available under these terms and
    conditions.


    Section 1 -- Definitions.

    a. Adapted Material means material subject to Copyright and Similar
        Rights that is derived from or based upon the Licensed Material
        and in which the Licensed Material is translated, altered,
        arranged, transformed, or otherwise modified in a manner requiring
        permission under the Copyright and Similar Rights held by the
        Licensor. For purposes of this Public License, where the Licensed
        Material is a musical work, performance, or sound recording,
        Adapted Material is always produced where the Licensed Material is
        synched in timed relation with a moving image.

    b. Adapter's License means the license You apply to Your Copyright
        and Similar Rights in Your contributions to Adapted Material in
        accordance with the terms and conditions of this Public License.

    c. BY-SA Compatible License means a license listed at
        creativecommons.org/compatiblelicenses, approved by Creative
        Commons as essentially the equivalent of this Public License.

    d. Copyright and Similar Rights means copyright and/or similar rights
        closely related to copyright including, without limitation,
        performance, broadcast, sound recording, and Sui Generis Database
        Rights, without regard to how the rights are labeled or
        categorized. For purposes of this Public License, the rights
        specified in Section 2(b)(1)-(2) are not Copyright and Similar
        Rights.

    e. Effective Technological Measures means those measures that, in the
        absence of proper authority, may not be circumvented under laws
        fulfilling obligations under Article 11 of the WIPO Copyright
        Treaty adopted on December 20, 1996, and/or similar international
        agreements.

    f. Exceptions and Limitations means fair use, fair dealing, and/or
        any other exception or limitation to Copyright and Similar Rights
        that applies to Your use of the Licensed Material.

    g. License Elements means the license attributes listed in the name
        of a Creative Commons Public License. The License Elements of this
        Public License are Attribution and ShareAlike.

    h. Licensed Material means the artistic or literary work, database,
        or other material to which the Licensor applied this Public
        License.

    i. Licensed Rights means the rights granted to You subject to the
        terms and conditions of this Public License, which are limited to
        all Copyright and Similar Rights that apply to Your use of the
        Licensed Material and that the Licensor has authority to license.

    j. Licensor means the individual(s) or entity(ies) granting rights
        under this Public License.

    k. Share means to provide material to the public by any means or
        process that requires permission under the Licensed Rights, such
        as reproduction, public display, public performance, distribution,
        dissemination, communication, or importation, and to make material
        available to the public including in ways that members of the
        public may access the material from a place and at a time
        individually chosen by them.

    l. Sui Generis Database Rights means rights other than copyright
        resulting from Directive 96/9/EC of the European Parliament and of
        the Council of 11 March 1996 on the legal protection of databases,
        as amended and/or succeeded, as well as other essentially
        equivalent rights anywhere in the world.

    m. You means the individual or entity exercising the Licensed Rights
        under this Public License. Your has a corresponding meaning.


    Section 2 -- Scope.

    a. License grant.

        1. Subject to the terms and conditions of this Public License,
            the Licensor hereby grants You a worldwide, royalty-free,
            non-sublicensable, non-exclusive, irrevocable license to
            exercise the Licensed Rights in the Licensed Material to:

                a. reproduce and Share the Licensed Material, in whole or
                in part; and

                b. produce, reproduce, and Share Adapted Material.

        2. Exceptions and Limitations. For the avoidance of doubt, where
            Exceptions and Limitations apply to Your use, this Public
            License does not apply, and You do not need to comply with
            its terms and conditions.

        3. Term. The term of this Public License is specified in Section
            6(a).

        4. Media and formats; technical modifications allowed. The
            Licensor authorizes You to exercise the Licensed Rights in
            all media and formats whether now known or hereafter created,
            and to make technical modifications necessary to do so. The
            Licensor waives and/or agrees not to assert any right or
            authority to forbid You from making technical modifications
            necessary to exercise the Licensed Rights, including
            technical modifications necessary to circumvent Effective
            Technological Measures. For purposes of this Public License,
            simply making modifications authorized by this Section 2(a)
            (4) never produces Adapted Material.

        5. Downstream recipients.

                a. Offer from the Licensor -- Licensed Material. Every
                recipient of the Licensed Material automatically
                receives an offer from the Licensor to exercise the
                Licensed Rights under the terms and conditions of this
                Public License.

                b. Additional offer from the Licensor -- Adapted Material.
                Every recipient of Adapted Material from You
                automatically receives an offer from the Licensor to
                exercise the Licensed Rights in the Adapted Material
                under the conditions of the Adapter's License You apply.

                c. No downstream restrictions. You may not offer or impose
                any additional or different terms or conditions on, or
                apply any Effective Technological Measures to, the
                Licensed Material if doing so restricts exercise of the
                Licensed Rights by any recipient of the Licensed
                Material.

        6. No endorsement. Nothing in this Public License constitutes or
            may be construed as permission to assert or imply that You
            are, or that Your use of the Licensed Material is, connected
            with, or sponsored, endorsed, or granted official status by,
            the Licensor or others designated to receive attribution as
            provided in Section 3(a)(1)(A)(i).

    b. Other rights.

        1. Moral rights, such as the right of integrity, are not
            licensed under this Public License, nor are publicity,
            privacy, and/or other similar personality rights; however, to
            the extent possible, the Licensor waives and/or agrees not to
            assert any such rights held by the Licensor to the limited
            extent necessary to allow You to exercise the Licensed
            Rights, but not otherwise.

        2. Patent and trademark rights are not licensed under this
            Public License.

        3. To the extent possible, the Licensor waives any right to
            collect royalties from You for the exercise of the Licensed
            Rights, whether directly or through a collecting society
            under any voluntary or waivable statutory or compulsory
            licensing scheme. In all other cases the Licensor expressly
            reserves any right to collect such royalties.


    Section 3 -- License Conditions.

    Your exercise of the Licensed Rights is expressly made subject to the
    following conditions.

    a. Attribution.

        1. If You Share the Licensed Material (including in modified
            form), You must:

                a. retain the following if it is supplied by the Licensor
                with the Licensed Material:

                    i. identification of the creator(s) of the Licensed
                        Material and any others designated to receive
                        attribution, in any reasonable manner requested by
                        the Licensor (including by pseudonym if
                        designated);

                    ii. a copyright notice;

                iii. a notice that refers to this Public License;

                    iv. a notice that refers to the disclaimer of
                        warranties;

                    v. a URI or hyperlink to the Licensed Material to the
                        extent reasonably practicable;

                b. indicate if You modified the Licensed Material and
                retain an indication of any previous modifications; and

                c. indicate the Licensed Material is licensed under this
                Public License, and include the text of, or the URI or
                hyperlink to, this Public License.

        2. You may satisfy the conditions in Section 3(a)(1) in any
            reasonable manner based on the medium, means, and context in
            which You Share the Licensed Material. For example, it may be
            reasonable to satisfy the conditions by providing a URI or
            hyperlink to a resource that includes the required
            information.

        3. If requested by the Licensor, You must remove any of the
            information required by Section 3(a)(1)(A) to the extent
            reasonably practicable.

    b. ShareAlike.

        In addition to the conditions in Section 3(a), if You Share
        Adapted Material You produce, the following conditions also apply.

        1. The Adapter's License You apply must be a Creative Commons
            license with the same License Elements, this version or
            later, or a BY-SA Compatible License.

        2. You must include the text of, or the URI or hyperlink to, the
            Adapter's License You apply. You may satisfy this condition
            in any reasonable manner based on the medium, means, and
            context in which You Share Adapted Material.

        3. You may not offer or impose any additional or different terms
            or conditions on, or apply any Effective Technological
            Measures to, Adapted Material that restrict exercise of the
            rights granted under the Adapter's License You apply.


    Section 4 -- Sui Generis Database Rights.

    Where the Licensed Rights include Sui Generis Database Rights that
    apply to Your use of the Licensed Material:

    a. for the avoidance of doubt, Section 2(a)(1) grants You the right
        to extract, reuse, reproduce, and Share all or a substantial
        portion of the contents of the database;

    b. if You include all or a substantial portion of the database
        contents in a database in which You have Sui Generis Database
        Rights, then the database in which You have Sui Generis Database
        Rights (but not its individual contents) is Adapted Material,
        including for purposes of Section 3(b); and

    c. You must comply with the conditions in Section 3(a) if You Share
        all or a substantial portion of the contents of the database.

    For the avoidance of doubt, this Section 4 supplements and does not
    replace Your obligations under this Public License where the Licensed
    Rights include other Copyright and Similar Rights.


    Section 5 -- Disclaimer of Warranties and Limitation of Liability.

    a. UNLESS OTHERWISE SEPARATELY UNDERTAKEN BY THE LICENSOR, TO THE
        EXTENT POSSIBLE, THE LICENSOR OFFERS THE LICENSED MATERIAL AS-IS
        AND AS-AVAILABLE, AND MAKES NO REPRESENTATIONS OR WARRANTIES OF
        ANY KIND CONCERNING THE LICENSED MATERIAL, WHETHER EXPRESS,
        IMPLIED, STATUTORY, OR OTHER. THIS INCLUDES, WITHOUT LIMITATION,
        WARRANTIES OF TITLE, MERCHANTABILITY, FITNESS FOR A PARTICULAR
        PURPOSE, NON-INFRINGEMENT, ABSENCE OF LATENT OR OTHER DEFECTS,
        ACCURACY, OR THE PRESENCE OR ABSENCE OF ERRORS, WHETHER OR NOT
        KNOWN OR DISCOVERABLE. WHERE DISCLAIMERS OF WARRANTIES ARE NOT
        ALLOWED IN FULL OR IN PART, THIS DISCLAIMER MAY NOT APPLY TO YOU.

    b. TO THE EXTENT POSSIBLE, IN NO EVENT WILL THE LICENSOR BE LIABLE
        TO YOU ON ANY LEGAL THEORY (INCLUDING, WITHOUT LIMITATION,
        NEGLIGENCE) OR OTHERWISE FOR ANY DIRECT, SPECIAL, INDIRECT,
        INCIDENTAL, CONSEQUENTIAL, PUNITIVE, EXEMPLARY, OR OTHER LOSSES,
        COSTS, EXPENSES, OR DAMAGES ARISING OUT OF THIS PUBLIC LICENSE OR
        USE OF THE LICENSED MATERIAL, EVEN IF THE LICENSOR HAS BEEN
        ADVISED OF THE POSSIBILITY OF SUCH LOSSES, COSTS, EXPENSES, OR
        DAMAGES. WHERE A LIMITATION OF LIABILITY IS NOT ALLOWED IN FULL OR
        IN PART, THIS LIMITATION MAY NOT APPLY TO YOU.

    c. The disclaimer of warranties and limitation of liability provided
        above shall be interpreted in a manner that, to the extent
        possible, most closely approximates an absolute disclaimer and
        waiver of all liability.


    Section 6 -- Term and Termination.

    a. This Public License applies for the term of the Copyright and
        Similar Rights licensed here. However, if You fail to comply with
        this Public License, then Your rights under this Public License
        terminate automatically.

    b. Where Your right to use the Licensed Material has terminated under
        Section 6(a), it reinstates:

        1. automatically as of the date the violation is cured, provided
            it is cured within 30 days of Your discovery of the
            violation; or

        2. upon express reinstatement by the Licensor.

        For the avoidance of doubt, this Section 6(b) does not affect any
        right the Licensor may have to seek remedies for Your violations
        of this Public License.

    c. For the avoidance of doubt, the Licensor may also offer the
        Licensed Material under separate terms or conditions or stop
        distributing the Licensed Material at any time; however, doing so
        will not terminate this Public License.

    d. Sections 1, 5, 6, 7, and 8 survive termination of this Public
        License.


    Section 7 -- Other Terms and Conditions.

    a. The Licensor shall not be bound by any additional or different
        terms or conditions communicated by You unless expressly agreed.

    b. Any arrangements, understandings, or agreements regarding the
        Licensed Material not stated herein are separate from and
        independent of the terms and conditions of this Public License.


    Section 8 -- Interpretation.

    a. For the avoidance of doubt, this Public License does not, and
        shall not be interpreted to, reduce, limit, restrict, or impose
        conditions on any use of the Licensed Material that could lawfully
        be made without permission under this Public License.

    b. To the extent possible, if any provision of this Public License is
        deemed unenforceable, it shall be automatically reformed to the
        minimum extent necessary to make it enforceable. If the provision
        cannot be reformed, it shall be severed from this Public License
        without affecting the enforceability of the remaining terms and
        conditions.

    c. No term or condition of this Public License will be waived and no
        failure to comply consented to unless expressly agreed to by the
        Licensor.

    d. Nothing in this Public License constitutes or may be interpreted
        as a limitation upon, or waiver of, any privileges and immunities
        that apply to the Licensor or You, including from the legal
        processes of any jurisdiction or authority.


    =======================================================================

    Creative Commons is not a party to its public
    licenses. Notwithstanding, Creative Commons may elect to apply one of
    its public licenses to material it publishes and in those instances
    will be considered the “Licensor.” The text of the Creative Commons
    public licenses is dedicated to the public domain under the CC0 Public
    Domain Dedication. Except for the limited purpose of indicating that
    material is shared under a Creative Commons public license or as
    otherwise permitted by the Creative Commons policies published at
    creativecommons.org/policies, Creative Commons does not authorize the
    use of the trademark "Creative Commons" or any other trademark or logo
    of Creative Commons without its prior written consent including,
    without limitation, in connection with any unauthorized modifications
    to any of its public licenses or any other arrangements,
    understandings, or agreements concerning use of licensed material. For
    the avoidance of doubt, this paragraph does not form part of the
    public licenses.

    Creative Commons may be contacted at creativecommons.org.

</details>

### Other Credits
- [Riemer's 2D & 3D Monogame Tutorials](https://github.com/SimonDarksideJ/XNAGameStudio/wiki/RiemersArchiveOverview)
- [Process.Start for URLs on .NET Core](https://brockallen.com/2016/09/24/process-start-for-urls-on-net-core/)
- [RB Whitaker's Wiki](http://rbwhitaker.wikidot.com/3d-tutorials)
- [Using NPM packages in Blazor](https://brianlagunas.com/using-npm-packages-in-blazor/)
- [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/)
- [THREE.js Manual](https://threejs.org/manual/)
- [THREE.js Documentation](https://threejs.org/docs/index.html#manual/en/introduction/Creating-a-scene)
